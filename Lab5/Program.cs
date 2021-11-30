using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int [7];
            int S = 0;
            int R;
            for (int i = 0; i < 7; i++)
            {
                array [i] = Convert.ToInt32(Console.ReadLine());
                S = S + array [i];
            }
            R = S / 7;
            Console.WriteLine(R);
            Console.ReadKey();
        }
    }
}
