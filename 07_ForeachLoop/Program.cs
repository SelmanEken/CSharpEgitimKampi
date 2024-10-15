using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1;2;3;4)

            //1:Değişken türü
            //2:Değişken adı
            //3:In
            //4:Liste,Koleksiyon Dizi

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 2, 345, 65, 778, 456, 3646, 3665, 66, 5445, 33 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 2, 345, 65, 778, 456, 3646, 3665, 66, 5445, 33 };
            //int toplam = 0;
            //foreach (int number in numbers)
            //{
            //    toplam += number;
            //}
            //Console.WriteLine(toplam);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Örnek sınav sistemi uygulaması

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var: ");
            int studentcount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");


            //öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentNames = new string[studentcount];
            double[] studentExamAvg = new double[studentcount];

            for (int i = 0; i < studentcount; i++)
            {
                Console.Write($"{i + 1} .öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //her öğrenci için 3 sınav notu girişi

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; //notları toplama işlemi
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }

            //sınav ortalamaları
            for (int i = 0; i < studentcount; i++)
            {

                Console.WriteLine("-----------------------");

                Console.WriteLine($"{studentNames[i]} isimli öğrencinin ortalaması: {studentExamAvg[i]}");

                //öğrencinin ortalaması ve geçip kalma durumu
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci dersi geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci dersten kaldı.");
                }

            }
            #endregion 

            Console.Read();

        }
    }
}