using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Idiot_Test {
    public partial class ctrlQuestion : UserControl {
        private QuestionEntry question;
        public int ReturnedValue { get; set; } = -1;
        public ctrlQuestion(QuestionEntry question) {
            InitializeComponent();

            this.question = question;
            setUpdate();
        }
        Random random = new Random();
        private void setUpdate() {
            // 76 + 25 * i
            lblQuestion.Text = question.Question;
            int i = 0;
            bool set = false;

            var answers = question.Answers.OrderBy(x => random.Next())
                .ToDictionary(item => item.Key, item => item.Value);
            foreach (var answer in answers) {
                // We're gonna take a shortcut, but that doesn't
                // mean this is bad, just ugly ;).
                RadioButton rdb = new RadioButton {
                    Name = "rdbOption" + answer.Value,
                    Text = answer.Key,
                    Location = new Point(14, 90 + 25 * i),
                    Anchor = AnchorStyles.Bottom | AnchorStyles.Left,
                    Width = this.Width - 10
                };
                if (!set) {
                    set = true;
                    rdb.Checked = true;
                }
                this.Controls.Add(rdb);

                i++;
            }
            this.Refresh();
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            foreach (Control ctrl in this.Controls) {
                if (ctrl.GetType() == typeof(RadioButton)) {
                    if (((RadioButton)ctrl).Checked) {
                        ReturnedValue = int.Parse(ctrl.Name.Remove(0, 9));
                        break;
                    }
                }
            }
        }
    }
}
