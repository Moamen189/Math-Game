using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project
{
    class Clslevel
    {
        public int levelStart { get; set; }
        public int levelEnd { get; set; }
        public int OperatorCount { get; set; }
        public int RightAnswerCount { get; set; }
        public int  WrongAnswerCount { get; set; }

        public MathOperator GetNextNumber()
        {
            Random myRandom = new Random();
            MathOperator currentNumbers;
            currentNumbers.firstNumber = myRandom.Next(levelStart, levelEnd);
            currentNumbers.secondNumber = myRandom.Next(levelStart, levelEnd);
            currentNumbers.Operator = currentNumbers.Operator = myRandom.Next(1, OperatorCount);

            return currentNumbers;

        }
    }

    
}
