using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MontsOfYear montsOfYear = new MontsOfYear();
            foreach (string item in montsOfYear)
            {
                Console.Write($"{item} ");

            }
            Console.WriteLine();

        }
    }
    
}
