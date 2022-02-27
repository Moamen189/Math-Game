using System;
using Game_Project.Bl;

namespace Game_Project
{
    public struct MathOperator
    {
        public int firstNumber;
        public int secondNumber;
        public int Operator;

    }

    public enum levelStatus
    {
        inProgress = 1,
        pormoted = 2,
        GameOver = 3
    }
    class Program
    {
        public static IMathOperatorLevel GetLevelObject(int nlevelNumber)       
        {
            IMathOperatorLevel oIMathOperatorLevel = new levelOne();
            switch (nlevelNumber)
            {
                case 1:
                    oIMathOperatorLevel = new levelOne();
                    break;
                case 2:
                    oIMathOperatorLevel = new levelTwo();
                    break;
                case 3:
                    oIMathOperatorLevel = new levelThree();
                    break;
                case 4:
                    oIMathOperatorLevel = new levelFour();
                    break;
                case 5:
                    oIMathOperatorLevel = new levelFive();
                    break;


            }
            return oIMathOperatorLevel;

        }
        //public static MathOperator GetNextNumber(int nlevelNumber , out Clslevel oClslevel)
        //{
        //    Random myRandom = new Random();
        //    MathOperator currentNumbers;
        //     oClslevel = new Clslevel();
        //    switch (nlevelNumber)
        //    {
        //        case 1:
        //            oClslevel.levelStart = 0;
        //            oClslevel.levelEnd = 10;
        //            oClslevel.OperatorCount = 1;
        //            oClslevel.RightAnswerCount = 3;
        //            oClslevel.WrongAnswerCount = 5;
        //            break;
        //        case 2:
        //            oClslevel.levelStart = 0;
        //            oClslevel.levelEnd = 20;
        //            oClslevel.OperatorCount = 2;
        //            oClslevel.RightAnswerCount = 3;
        //            oClslevel.WrongAnswerCount = 7;
        //            break;
        //        case 3:
        //            oClslevel.levelStart = 0;
        //            oClslevel.levelEnd = 20;
        //            oClslevel.OperatorCount = 3;
        //            oClslevel.RightAnswerCount = 10;
        //            oClslevel.WrongAnswerCount = 4;
        //            break;
        //        case 4:
        //            oClslevel.levelStart = 0;
        //            oClslevel.levelEnd = 30;
        //            oClslevel.OperatorCount = 3;
        //            oClslevel.RightAnswerCount = 4;
        //            oClslevel.WrongAnswerCount = 10;
        //            break;
        //        case 5:
        //            oClslevel.levelStart = 0;
        //            oClslevel.levelEnd = 50;
        //            oClslevel.OperatorCount = 3;
        //            oClslevel.RightAnswerCount = 5;
        //            oClslevel.WrongAnswerCount = 12;
        //            break;


        //    }
           

     
             
        //    return oClslevel.GetNextNumber();

        //}

        public static bool CheckResult(MathOperator currentNumbers , int result)
        {
            bool isRightAnswer = false;
            switch (currentNumbers.Operator)
            {
                case 1:
                    isRightAnswer = (result == currentNumbers.firstNumber + currentNumbers.secondNumber);
                    break;
                case 2:
                    isRightAnswer = (result == currentNumbers.firstNumber - currentNumbers.secondNumber);
                    break;
                case 3:
                    isRightAnswer = (result == currentNumbers.firstNumber * currentNumbers.secondNumber);
                    break;
            }

            return isRightAnswer;
        }

        //public static void CheckAnswerCount(int rightCount , int wrongCount, IMathOperatorLevel oClslevel, int levelnumber , out levelStatus status)
        //{
          
        //    status = levelStatus.inProgress;

        //    if (rightCount == oClslevel.RightAnswerCount)
        //    {
        //        Console.WriteLine("Level Pormoted");
        //        status = levelStatus.pormoted;
        //    }

        //    if (wrongCount == oClslevel.WrongAnswerCount)
        //    {
        //        Console.WriteLine("Game Over");
        //        status = levelStatus.GameOver;

        //    }

        //}



        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Math Operator Test");

            char exit = 'a';
           
            int RightAnswerCount = 0;
            int WrongAnswerCount = 0;
            

            IMathOperatorLevel myCurrentLevel = GetLevelObject(1);

            while (exit != 'e')
            {
                if(myCurrentLevel == null)
                {
                    Console.WriteLine("Congratulations Game Over");
                    break;
                }
                bool isRightAnswer = false;
                MathOperator currentNumbers = myCurrentLevel.GetNextNumber();


                Console.WriteLine($"your Current level is {myCurrentLevel.levelNumber}");

                Console.WriteLine($"first Number {currentNumbers.firstNumber} second Number {currentNumbers.secondNumber} operator is {currentNumbers.Operator}");
                Console.WriteLine("************************************");
                Console.WriteLine("Please Enter Result");
                int result = Convert.ToInt32(Console.ReadLine());
                isRightAnswer = CheckResult(currentNumbers, result);



                if (isRightAnswer)
                {
                    Console.WriteLine("Right Answer");
                    RightAnswerCount++;
                }
                else
                {
                    Console.WriteLine("Wrong Answer");
                    WrongAnswerCount++;
                }

                myCurrentLevel = myCurrentLevel.GetNextLevel(RightAnswerCount, WrongAnswerCount);
               
                    



                Console.WriteLine("************************************");
                Console.WriteLine("Please Enter e for exit or press any Key");
                exit = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
