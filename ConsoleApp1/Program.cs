using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ogrenci;
            int meter = 0;
            Console.Write("Enter How Many Students Are In The Class: ");
            int number=Convert.ToInt32(Console.ReadLine());
            string[]  name= new string[number];
            int[] result= new int[number];
            for(int i = 0; i < result.Length; i++)
            {
                Console.Clear();
                Console.WriteLine($" Enter The Name of The {(i+1)}. Student");
                name[i]= Console.ReadLine();
            }
            for (int i = 0; i < result.Length; i++)
            {
                Console.Clear();
                Console.WriteLine(" Enter The Grade of The Student Named " +name[i]);
                result[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] > 50)
                {
                    Console.WriteLine($"{name[i]} Got {result[i]} In English Class And {name[i]} PASSED The Lesson");
                    meter++;
                }else
                {
                    Console.WriteLine($"{name[i]} Got {result[i]} In English Class And {name[i]} FAILED The Class");
                }
            }
            int sayi = result[0];
            for(int i = 0; i < result.Length; i++)
            {
                if (result[i]>=sayi)
                {
                    sayi = i;

                }

            }
            Console.Clear();
            Console.WriteLine($"{meter} Student Passed The Lesson");
            Console.WriteLine("************************");
            Console.WriteLine($"{name[sayi]} En yüksek Nota sahip öğrenci");
            Console.WriteLine("************************");
            Console.ReadKey();
        }
    }
}
