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
    public partial class frmQuiz : Form {
        int selectedQuestion = 0;
        List<QuestionEntry> questions;
        int score = 0;

        public frmQuiz() {
            InitializeComponent();
        }
        public frmQuiz(List<QuestionEntry> questions) {
            InitializeComponent();

            this.questions = questions;

            Controls.Add(getControl(questions[0]));
        }
        private ctrlQuestion getControl(QuestionEntry question) {
            var q = new ctrlQuestion(question) {
                Dock = DockStyle.Fill,
                Name = "ctrlQuestionCurrent"
            };

            q.btnSubmit.Click += (object sender, EventArgs e) => {
                Control c = (Control)sender;
                ctrlQuestion parent = (ctrlQuestion)c.Parent;
                score += parent.ReturnedValue;

                nextQuestion();
            };

            return q;
        }
        private void nextQuestion() {
            Controls.Find("ctrlQuestionCurrent", false)[0].Dispose();

            if (selectedQuestion < questions.Count - 1) {
                selectedQuestion++;
                Controls.Add(getControl(questions[selectedQuestion]));
            } else {
                // They've finished. Now we must scale the score!
                // It should depend on the quiz. We'll scale it based on MAXIMUM points.
                // We shall have 6 categories.
                // Normal, meme, dank meme, idiot, complete idiot, insanely idiotic.
                double percent = ((double)score / getMaxPoints()) * 100;
                string idiocyLevel = percent >= 0 && percent < 16 ? "Normal" :
                                     percent >= 16 && percent < 32 ? "Meme" :
                                     percent >= 32 && percent < 48 ? "Dank Meme" :
                                     percent >= 48 && percent < 64 ? "Idiot" :
                                     percent >= 64 && percent < 70 ? "Complete Idiot" :
                                     percent >= 70 ? "Insanely Idiotic" : "Impossible!";
                ctrlResult result = new ctrlResult(idiocyLevel + 
                    " (" + (int)percent + "%)") {
                    Dock = DockStyle.Fill
                };

                Controls.Add(result);
            }
        }
        private double getMaxPoints() {
            double cMax = 0;

            foreach (var q in questions) {
                double aMax = 0;
                foreach (var a in q.Answers) {
                    if (a.Value > aMax) aMax = a.Value;
                }

                cMax += aMax;
            }

            return cMax;
        }
        private void frmQuiz_Load(object sender, EventArgs e) {
        }
    }
}
