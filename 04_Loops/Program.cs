﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Döngüler

            #region For Döngüsü

            //int i;
            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# egitim kampı");
            //}

            //for (int i = 0; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i<=50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishvalue = int .Parse(Console.ReadLine());

            //for (int i = 1; i <= finishvalue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}

            //Console.Write("Lütfen sayı giriniz: ");
            //int sayi = int.Parse(Console.ReadLine());
            //int toplam = 0;

            //for (int i = 0; i <= sayi; i++)
            //{
            //    toplam += i;
            //    Console.Write(toplam);
            //}
            //Console.WriteLine("Sayıların Toplamı: " + toplam);



            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalvalue = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    totalvalue += i;
            //}
            //Console.WriteLine(totalvalue);

            //int toplam = 0;

            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        toplam += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("-------");
            //Console.WriteLine(toplam);

            //int count = 0;

            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("--------");
            //Console.WriteLine(count);

            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + " .Saat Sonunda: " + bacterium);
            //}



            #endregion

            #region While Döngüsü

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            #endregion

            #region Örnek Soru
            //klavyeden girilen 3 basamaklı sayının basamakları toplamı yazan prog

            int number, ones, tens, hundreds, sum;
            Console.Write("Lütfen sayı giriniz: ");
            number = int.Parse(Console.ReadLine());
            ones = number % 10;
            tens = (number % 100) / 10;
            hundreds = number / 100;
            sum = ones + tens + hundreds;

            Console.WriteLine(hundreds + "-" + tens + "-" + ones);
            Console.WriteLine("Toplam: " + sum);


            #endregion
            Console.Read();

        }
    }
}
