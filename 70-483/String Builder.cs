using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70_483
{
    class String_Builder
    {
        public String_Builder()
        {
            //StringBuilder stringBuilder = new StringBuilder("HelloWorld");
            ////Append Adds to the end of the string
            ////stringBuilder.Append("Test");
            //Console.WriteLine(stringBuilder);
            //Console.ReadLine();

            ////AppendFormat Replaces a format specifier passed in a string with formatted text
            //int MyInt = 25;
            //StringBuilder MyStringBuilder = new StringBuilder("Your total is ");
            //MyStringBuilder.AppendFormat("{0:C} ", MyInt);
            //Console.WriteLine(MyStringBuilder);
            //Console.ReadLine();

            ////Inserts a string or object into the specified index of the current StringBuilder.
            //StringBuilder MyStringBuilderInsert = new StringBuilder("Hello World!");
            //MyStringBuilderInsert.Insert(6, "Beautiful ");
            //Console.WriteLine(MyStringBuilderInsert);
            //Console.ReadLine();

            //Remove Removes a specified number of characters from the current StringBuilder.
            //StringBuilder MyStringBuilderRemove = new StringBuilder("Hello World!");
            //MyStringBuilderRemove.Remove(5, 7);
            //Console.WriteLine(MyStringBuilderRemove);
            //Console.ReadLine();

            //Replace Replaces a specified character at a specified index.
            StringBuilder MyStringBuilderReplace = new StringBuilder("Hello World!");
            MyStringBuilderReplace.Replace('!', '?');
            Console.WriteLine(MyStringBuilderReplace);
            Console.ReadLine();


        }


    }
}
