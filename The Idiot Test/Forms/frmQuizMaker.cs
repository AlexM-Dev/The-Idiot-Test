using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Idiot_Test {
    public partial class frmQuizMaker : Form {
        private List<QuestionEntry> questions =
            new List<QuestionEntry>(); // Field -> not property. ;)
        private int tIndex = 0;
        public frmQuizMaker() {
            InitializeComponent();
        }

        int previousValue = 0;
        List<ctrlAnswer> answers = new List<ctrlAnswer>();
        private void updateAnswers() {
            int diff = (int)nudAmount.Value - previousValue;

            // We should remove controls.
            // (Modify the answers list)
            if (diff <= 0) {
                for (int i = 0; i < answers.Count; i++)
                    if (i >= nudAmount.Value) answers.Remove(answers[i]);
            }

            // We should add controls.
            // (Modify the answers list)
            for (int i = previousValue; i < nudAmount.Value; i++) {
                int yValue = 80 + i * 61;

                ctrlAnswer answer = new ctrlAnswer {
                    Parent = pnlQuestion,
                    Location = new Point(22, yValue),
                    Name = "ctrlAnswer" + i
                };

                answers.Add(answer);
            }
        }
        private void updateInterface() {
            // Apply all changes that were made to the list.
            foreach (var a in getAnswers()) {
                if (!answers.Contains(a))
                    pnlQuestion.Controls.Remove(a);
            }

            foreach (ctrlAnswer answer in answers) {
                if (!pnlQuestion.Controls.Contains(answer))
                    pnlQuestion.Controls.Add(answer);
            }

            previousValue = (int)nudAmount.Value;
        }
        private void clearQuestion() {
            txtQuestion.Clear();

            nudAmount.Value = 0;
            answers = new List<ctrlAnswer>();
            updateAnswers();
            updateInterface();

            pnlQuestion.Hide();
        }
        private bool isModified() {
            return (txtQuestion.Modified || nudAmount.Value > 0);
        }
        private List<ctrlAnswer> getAnswers() {
            List<ctrlAnswer> controls = new List<ctrlAnswer>();
            foreach (Control c in pnlQuestion.Controls)
                if (c.GetType() == typeof(ctrlAnswer))
                    controls.Add((ctrlAnswer)c);

            return controls;
        }
        private void nudAmount_ValueChanged(object sender, EventArgs e) {
            updateAnswers();
            updateInterface();
        }
        private void btnSubmit_Click(object sender, EventArgs e) {
            QuestionEntry entry = new QuestionEntry();
            entry.Question = txtQuestion.Text;
            entry.Answers = new Dictionary<string, int>();

            foreach (var answer in answers) {
                string answerString = answer.txtAnswerText.Text;

                int answerValue = answer.txtAnswerValue.Text.Length == 0 ? 0 :
                    int.Parse(answer.txtAnswerValue.Text);

                try {
                    entry.Answers.Add(answerString, answerValue);
                } catch {
                    MessageBox.Show("An error occurred, please try again.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            questions.Add(entry);
            lstQuestions.Items.Add(tIndex + " - " + entry.Question);

            tIndex++;

            clearQuestion();
            pnlQuestion.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (isModified()) {
                var message = MessageBox.Show("Are you sure you wish to add" +
                    " a new question/clear your existing work?",
                    "Are you sure?", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (message == DialogResult.No) return;
            }

            clearQuestion();
            pnlQuestion.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e) {
            var message = MessageBox.Show("Are you sure you wish to" +
                " remove this question?", "Are you sure?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes &&
                lstQuestions.SelectedItems.Count > 0) {
                int index = lstQuestions.SelectedIndex;

                lstQuestions.Items.RemoveAt(index);
                questions.RemoveAt(index);
            }
        }

        private void lstQuestions_SelectedIndexChanged(object sender, EventArgs e) {
            if (isModified()) {
                var message = MessageBox.Show("Are you sure you wish to edit" +
                    " another question and clear your existing work?",
                    "Are you sure?", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (message == DialogResult.No) return;
            }
            if (lstQuestions.SelectedIndices.Count == 0) return;

            clearQuestion();
            pnlQuestion.Show();

            QuestionEntry entry = questions[lstQuestions.SelectedIndex];
            txtQuestion.Text = entry.Question;
            nudAmount.Value = entry.Answers.Count;
            for (int i = 0; i < nudAmount.Value; i++) {
                foreach (var controlAnswer in getAnswers()) {
                    if (int.Parse(controlAnswer.Name.Remove(0, 10)) == i) {
                        controlAnswer.txtAnswerText.Text =
                            entry.Answers.ElementAt(i).Key;
                        controlAnswer.txtAnswerValue.Text =
                            entry.Answers.ElementAt(i).Value.ToString();
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            using (SaveFileDialog sfd = new SaveFileDialog()) {
                sfd.Filter = "Test files (*.tsf)|*.tsf";
                if (sfd.ShowDialog() == DialogResult.OK)
                    qslib.BinaryFile.Save(sfd.FileName, questions);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            using (OpenFileDialog ofd = new OpenFileDialog()) {
                ofd.Filter = "Test files (*.tsf)|*.tsf";
                if (ofd.ShowDialog() == DialogResult.OK)
                    questions = qslib.BinaryFile.Load<
                        List<QuestionEntry>>(ofd.FileName);
                lstQuestions.Items.Clear();
                tIndex = 0;
                foreach (QuestionEntry entry in questions) {
                    lstQuestions.Items.Add(tIndex + " - " + entry.Question);
                    tIndex++;
                }
            }
        }
    }
}
