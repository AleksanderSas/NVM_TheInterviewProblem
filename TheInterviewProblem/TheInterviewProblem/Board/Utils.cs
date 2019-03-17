using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheInterviewProblem.Board
{
    public static class Utils
    {
        public static Direction OnLeft(this Direction dir)
        {
            return (Direction)(((int)dir + 3) % 4);
        }

        public static Direction OnRigth(this Direction dir)
        {
            return (Direction)(((int)dir + 1) % 4);
        }
    }
}
