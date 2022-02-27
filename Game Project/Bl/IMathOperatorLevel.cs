using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project.Bl
{
    interface IMathOperatorLevel
    {
        public int levelNumber { get; set; }
        public int levelStart { get;  }
        public int levelEnd { get;  }
        public int OperatorCount { get;  }
        public int RightAnswerCount { get;  }
        public int WrongAnswerCount { get; }
        public MathOperator GetNextNumber();
        //public levelStatus CheckAnswerCount(int rightCount, int wrongCount);
        public IMathOperatorLevel GetNextLevel(int rightCount, int wrongCount);
    }
}
