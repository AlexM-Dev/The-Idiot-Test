using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Idiot_Test {
    class Quiz {
        private static Random random = new Random();

        // Generates a new set of quiz questions from an
        // existing specified list of quiz questions.
        public static List<QuestionEntry> CreateQuiz(
            List<QuestionEntry> available, int max) {
            var questions = new List<QuestionEntry>();

            // The max exceeds the available questions amount!
            if (max > available.Count)
                return questions;
            List<int> set = new List<int>(
                getSet(available.Count, max)
            );

            for (int i = 0; i < max; i++) {
                int r = set[i];
                questions.Add(available[r]);
            }

            return questions;
        }

        private static HashSet<int> getSet(int rMax, int count) {
            var set = new HashSet<int>();

            while (set.Count < count)
                set.Add(random.Next(rMax));

            return set;
        }
    }
}
