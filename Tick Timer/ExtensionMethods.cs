using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tick_Timer
{
    public static class ExtensionMethods
    {
        public static int Length(this int number)
        {
            int result = 0;

            if (number < 10)
                result = 1;
            else if (number < 100)
                result = 2;
            else if (number < 1000)
                result = 3;
            else if (number < 10000)
                result = 4;
            else if (number < 100000)
                result = 5;

            return result;
        }
    }
}
