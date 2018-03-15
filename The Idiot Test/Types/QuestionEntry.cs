using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qslib;

namespace The_Idiot_Test {
    [Serializable()]
    public class QuestionEntry : SerializableObject {
        public string Question { get; set; }
        public Dictionary<string, int> Answers { get; set; }
        public QuestionEntry() {

        }
        public QuestionEntry(string question, Dictionary<string, int> answers) {
            this.Question = question;
            this.Answers = answers;
        }
    }
}
