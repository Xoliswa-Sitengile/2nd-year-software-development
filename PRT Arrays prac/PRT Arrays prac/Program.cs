using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRT_Arrays_prac
{
    class Program
    {
        static void Main(string[] args) //Xoliswa 223239828
        {
            int[,] nums = new int[3, 4] { { 6, 7, 9, 8 }, { 4, 2, 1, 3 }, { 9, 7, 0, 4 } };

            Console.WriteLine("Output 1");
            foreach (int i in nums) //printing out all nunbers
            {
                Console.Write("{0} ",i);
            }
            Console.WriteLine();
            Console.WriteLine("Option 2");
            foreach (int i in nums) //multiplying every element by 5
            {
                Console.Write("{0} ", i * 5);
            }
            Console.WriteLine();
           Console.WriteLine("Option 3"); // printing in reverse
            for (int k = 2; k >= 0; k--)
            {
                for (int a = 0; a <= 3;a++)
                {
                    Console.Write(nums[k,a] +" ");
                }
            }
            Console.ReadLine();      
        }
    }
}
