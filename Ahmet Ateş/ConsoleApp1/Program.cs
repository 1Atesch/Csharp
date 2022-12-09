using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {



            while (true)
            {
                Random ates = new Random();
                Console.WriteLine("Soru Sayısını Giriniz");
                int sS = Convert.ToInt32(Console.ReadLine());
                int[] random = new int[sS];
                for (int i = 0; i < random.Length; i++)
                {
                    random[i] = ates.Next(0, 10);
                    Console.WriteLine(random[i]);
                }

                Console.WriteLine("Oyuncu Sayısını Giriniz");
                int oS = Convert.ToInt32(Console.ReadLine());
                int[] puan = new int[oS];
                string[] oyuncu = new string[oS];
                for (int i = 0; i < oS; i++)
                {

                    puan[i] = 0;
                    Console.Clear();

                    Console.WriteLine($"{i + 1}. Oyuncunun İsmini Giriniz");
                    oyuncu[i] = Console.ReadLine();
                }
                for (int i = 0; i < sS; i++)
                {
                    Console.Clear();
                    for (int b = 0; b <= oS; b++)
                    {

                        Console.WriteLine($"Puanınız:{puan[b]}");
                        Console.WriteLine($"Rastgele Sayi:{random[i]}");
                        Console.WriteLine($" {oyuncu[b]} Tahminini Girsin");
                        int tahmin = Convert.ToInt32(Console.ReadLine());
                        if (random[i] == tahmin)
                        {
                            Console.WriteLine("Doğru Tahmin Ettiniz");
                            puan[b] += 10;
                            Console.Clear();
                        }
                        else
                        {
                            if (random[i] > tahmin)
                            {
                                Console.WriteLine("Yanlıs Tahmin Ettiniz");
                                puan[i] += 10 - (random[i] - tahmin);
                                Console.WriteLine(puan[b]);
                                Console.Clear();
                            }
                            else if (random[i] < tahmin)
                            {
                                Console.WriteLine("Yanlıs Tahmin Ettiniz");
                                puan[b] += 10 - (tahmin - random[i]);
                                Console.WriteLine($"{puan[b]} puan eklendi");
                                Console.Clear();
                            }
                        }

                    }
                }
                for (int i = 0; i <= oS; i++)
                {
                    Console.Write($"{oyuncu[i]} Puanı={puan[i]}");
                }

                Console.ReadKey();
            }
        }
    }
}