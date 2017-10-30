using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70_483
{
    class Chapter2
    {
    }
    #region Structs
    struct CreatingCustomStruct //Value type 
    {
        public int x, y;

        public CreatingCustomStruct(int p1, int p2)
        {
            x = p1;

            y = p2;
        }
    }

    #endregion

    #region Enums

    class CreatingEnums
    {
        static void Main(string[] args)
        {
            Days day = Days.sat;
            if ((byte)day == 1)
            {

            }

            //With Flags set i can assign multiple values to one enum

            Days readingDays = Days.Sun | Days.Mon;
        }

        public enum Gender { male, Female }

        [Flags] public enum Days : byte { sat = 1, Sun, Mon, Tues, Wed, Thurs, Fri }
    }
    #endregion

    #region NamedAndOptionalArguments
    class NamedAndOptionalArguments
    {
        void MyMethod(int firstArgument, string secondArgument = "Default", bool thirdArgument = false) { }

        void CallingMethod ()
        {
            MyMethod(1, thirdArgument: true);
        }
    }
    #endregion

    #region BoxingAnd Unboxing
    class Boxing
    {
        public Boxing()
        {
            // Created on the stack
            int x = 5;
            //Creted on the heap This is what boxing is 
            object o = x;
            // unboxing = boxed int unboxed from the heap and assigned to an int stack variab;e
            int y = (int)o;
        }
       
    }
    #endregion

}
