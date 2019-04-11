using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Multithread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Work1);
            Thread t2 = new Thread(Work2);
            t1.Start();t2.Start();

        }
        static void Work1()
        {
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("Work 1 is called "+i);
            }
        }
        static void Work2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Work 2 is called " + i);
            }
        }
    }
}
