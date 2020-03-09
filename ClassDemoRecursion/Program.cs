using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            RecursionWorker worker = new RecursionWorker();
            worker.Start();

            Console.ReadLine();
        }
    }
}
