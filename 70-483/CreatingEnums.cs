using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70_483
{
    class CreatingEnums
    {
        static void Main(string[] args)
        {
            Days day = Days.sat;
            if((byte)day == 1)
            {
               
            }

            //With Flags set i can assign multiple values to one enum

            Days readingDays = Days.Sun | Days.Mon;
        }

        public enum Gender { male,Female}

       [Flags] public enum Days : byte { sat = 1, Sun, Mon, Tues, Wed,Thurs,Fri}
    }
}
