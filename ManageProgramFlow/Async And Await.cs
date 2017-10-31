using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ManageProgramFlow
{
    class Async_And_Await
    {
        public Async_And_Await()
        {
            Console.WriteLine("Starting");
            var worker = new Worker();
            worker.DoWork();

            while(!worker.IsComplete)
            {
                Console.WriteLine(".");
                Thread.Sleep(100);
            }

            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }

    public class Worker
    {
        public bool IsComplete { get; private set; }

        public async void DoWork()
        {
            this.IsComplete = false;
            Console.WriteLine("Doing Work");

           await LongOperation();

            Console.WriteLine("Work Completed");

            IsComplete = true;
        }

        private Task LongOperation()
        {
            return Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Working!");
                Thread.Sleep(2000);
            });
        }
    }
}
