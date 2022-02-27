using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project.Bl
{
    class levelThree:IMathOperatorLevel
    {
        public int levelStart { get; } = 0;

        public int levelEnd { get; } = 20;

        public int OperatorCount { get; } = 3;

        public int RightAnswerCount { get; } = 10;

        public int WrongAnswerCount { get; } = 4;
        public int levelNumber { get; } = 3;

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
                return new levelFour();
            }

            if (wrongCount == WrongAnswerCount)
            {
                Console.WriteLine("Game Over");
                status = levelStatus.GameOver;


            }
            return new levelTwo();

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
