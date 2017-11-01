using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70_483
{
    class StringWritterAndStringReader
    {
        StringBuilder sb = new StringBuilder();
        public StringWritterAndStringReader()
        {
            //Call the Writer Method
            Writer();

            //Call the Reader Method
            Reader();
        }

       

        //Writer Method
        private void Writer()
        {
            StringWriter sw = new StringWriter(sb);
            Console.WriteLine("Welcome to the Profile Program");
            Console.Write("Name :");

            //Get the name from the console
            string name = Console.ReadLine();

            //Write to StringBuilder
            sw.WriteLine("Name :" + name);
            Console.Write("Country :");
            string country = Console.ReadLine();

            //Write to StringBuilder
            sw.WriteLine("Country :" + country);
            Console.Write("Age :");
            string age = Console.ReadLine();

            //Write to StringBuilder
            sw.WriteLine("Age :" + age);
            Console.WriteLine("Thank You");
            Console.WriteLine("Information Saved!");
            Console.WriteLine();

            //Close the stream
            sw.Flush();
            sw.Close();
            Console.ReadLine();
        }

        private void Reader()
        {
            StringReader sr = new StringReader(sb.ToString());
            Console.WriteLine("Reading Profile");

            //Peek to see if the next character exists
            while (sr.Peek() > -1)
            {
                //Read a line from the string and display it on the
                //console
                Console.WriteLine(sr.ReadLine());
            }

            Console.WriteLine("Data Read Complete!");
            //Close the string
            sr.Close();
        }
    }
}
