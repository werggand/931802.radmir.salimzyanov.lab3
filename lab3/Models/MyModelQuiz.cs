using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab3.Models
{
    public class MyModelQuiz
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
        public double answer { get; set; }
        public string oper { get; set; }

        public MyModelQuiz()
        {
            Random rnd = new Random();
            num1 = rnd.Next(20);
            num2 = rnd.Next(20);

            string[] operands = { "+", "-", "*", "/" };
            oper = operands[rnd.Next(4)];
        }


        public bool Check()
        {
            double correct = default;
            switch (oper)
            {
                case "+":
                    correct = num1 + num2;
                    break;
                case "-":
                    correct = num1 - num2;
                    break;
                case "*":
                    correct = num1 * num2;
                    break;
                case "/":
                    correct = num1 / num2;
                    break;
            }
            if (correct == answer)
                return true;
            else
                return false;
        }
    }
}
