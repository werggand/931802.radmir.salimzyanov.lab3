using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab3.Models
{
    public class MyModelAnswer
    {
        public List<MyModelQuiz> answers = new List<MyModelQuiz>();
        public int correct = 0;
        private static MyModelAnswer instance = null;
        public static MyModelAnswer Instance
        {
            get
            {
                if (instance == null)
                    instance = new MyModelAnswer();
                return instance;
            }
        }
        public void Add(MyModelQuiz quiz)
        {
            if (quiz.Check())
                correct++;
            answers.Add(quiz);
        }
    }
}
