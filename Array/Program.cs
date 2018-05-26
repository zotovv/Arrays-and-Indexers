using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray ar = new MyArray(8);

            ar.Min();
            ar.Min();
            ar.Sum();
            ar.Average();
            ar.Odd();

            Console.ReadKey();
        }
    }
}
