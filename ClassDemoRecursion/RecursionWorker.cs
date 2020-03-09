using System;

namespace ClassDemoRecursion
{
    class RecursionWorker
    {
        public void Start()
        {
            // Recursion1(17);
            
            for (int i = 1; i <= 12; i++)
            {
                counter = 0;
                long f = Fibunacci(i);
                Console.WriteLine($"Fibunacci {i} Antal {counter} res {f}");
            }

        }

        private static long counter = 0;


        public void Recursion1(int i)
        {
            // stop
            if (i == 0)
                return; // stopper

            // gøre et eller andet
            Console.WriteLine(i);

            // kalde sig selv - gerne med et mindre problem
            Recursion1(i - 1);
        }

        public long Fibunacci(int i)
        {
            counter++;

            // stop
            if (i == 1 || i == 2)
                return 1;

            
            return Fibunacci(i - 1) + Fibunacci(i - 2);
        }
    }
}