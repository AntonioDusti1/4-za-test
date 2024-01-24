using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] starbroj = new int[10];
            int[] novibroj = new int[10];
            int staribroj = 0;
            int novbroj = 0;

            while (true)
            {
                Console.Write("Upisi broj: ");
                int broj = int.Parse(Console.ReadLine());

                if (broj == 0 || staribroj + novbroj >= 10)
                    break;

                if (broj % 2 == 0)
                {
                    starbroj[novbroj] = broj;
                    novbroj++;
                }
                else
                {
                    starbroj[staribroj] = broj;
                    staribroj++;
                }
            }

            Console.WriteLine("Star broj:");
            for (int i = 0; i < staribroj; i++)
            {
                Console.WriteLine(starbroj[i]);
            }

            Console.WriteLine("Novi broj:");
            for (int i = 0; i < novbroj; i++)
            {
                Console.WriteLine(novibroj[i]);
            }
            Console.ReadLine();
        }
    }
}
