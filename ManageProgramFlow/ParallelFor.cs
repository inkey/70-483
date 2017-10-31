using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ManageProgramFlow
{
    class ParallelFor
    {
        public ParallelFor()
        {
               
            long totalSize = 0;

            String args = @"c:\windows\";
            if (args.Length == 1)
            {
                Console.WriteLine("There are no command line arguments.");
                return;
            }
            if (!Directory.Exists(args))
            {
                Console.WriteLine("The directory does not exist.");
                return;
            }

            String[] files = Directory.GetFiles(args);
            Parallel.For(0, files.Length,
                         index => {
                             FileInfo fi = new FileInfo(files[index]);
                             long size = fi.Length;
                             Interlocked.Add(ref totalSize, size);
                         });
            Console.WriteLine("Directory '{0}':", args[1]);
            Console.WriteLine("{0:N0} files, {1:N0} bytes", files.Length, totalSize);
            Console.ReadLine();
        }

    }
}
