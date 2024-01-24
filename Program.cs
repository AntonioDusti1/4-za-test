using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadnji
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] niz1 = { 1, 2, 3, 4, 5 };
            int[] niz2 = { 1, 2, 6, 4, 5 };
            int koliko = 0;

            for (int i = 0; i < niz1.Length; i++)
            {
                if (niz1[i] == niz2[i])
                {
                    koliko++;
                }
            }

            Console.WriteLine("Broj elementa sa istom vrijednosti na isti niz je: " + koliko);
            Console.ReadLine();
        }
    }
}
