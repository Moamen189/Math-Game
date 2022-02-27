using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project.Bl
{
    class levelFive:IMathOperatorLevel
    {
        public int levelStart { get; } = 0;

        public int levelEnd { get; } = 50;

        public int OperatorCount { get; } = 3;

        public int RightAnswerCount { get; } = 15;

        public int WrongAnswerCount { get; } = 7;
        public int levelNumber { get; } = 5;

        public levelStatus CheckAnswerCount(int rightCount, int wrongCount)
        {
            levelStatus status = levelStatus.inProgress;

            if (rightCount == RightAnswerCount)
            {
                Console.WriteLine("Level Pormoted");
                status = levelStatus.pormoted;
            }

            if (wrongCount == WrongAnswerCount)
            {
                Console.WriteLine("Game Over");
                status = levelStatus.GameOver;

            }
            return status;
        }

        public IMathOperatorLevel GetNextLevel(int rightCount, int wrongCount)
        {
            levelStatus status = levelStatus.inProgress;

            if (rightCount == RightAnswerCount)
            {
                Console.WriteLine("Level Pormoted");
                status = levelStatus.pormoted;
                return null;
            }

            if (wrongCount == WrongAnswerCount)
            {
                Console.WriteLine("Game Over");
                status = levelStatus.GameOver;


            }
            return new levelFive();


        }

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
