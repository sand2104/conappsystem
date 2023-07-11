using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conappsystem
{
    internal class Program
    {
        static void Main(string[]args)
        {
            for (int i = 1; i < 10; i++)
            {
                if (i == 7)
                {
                    goto end;
                }
                Console.WriteLine("i value: {0}", i);
            }
        end: Console.WriteLine("The end");
        }
    }
}

