using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using qslib;

namespace The_Idiot_Test {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e) {
            string temp = Path.GetTempFileName();
            File.WriteAllBytes(temp, Properties.Resources.Retard_test);
            var questions = BinaryFile.Load<List<QuestionEntry>>(temp);
            questions = Quiz.CreateQuiz(questions, questions.Count);

            using (var quiz = new frmQuiz(questions)) {
                quiz.ShowDialog();
                File.Delete(temp); //Although this is automatic, safer to do it.
            }
        }

        private void lblCreate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            using (frmQuizMaker maker = new frmQuizMaker())
                maker.ShowDialog();
        }

        private void btnCustom_Click(object sender, EventArgs e) {
            using (OpenFileDialog ofd = new OpenFileDialog()) {
                ofd.Filter = "Test files (*.tsf)|*.tsf";
                if (ofd.ShowDialog() == DialogResult.OK) {
                    var questions = BinaryFile.Load<
                        List<QuestionEntry>>(ofd.FileName);
                    questions = Quiz.CreateQuiz(questions, questions.Count);
                    using (var quiz = new frmQuiz(questions))
                        quiz.ShowDialog();
                }
            }
        }
    }
}
