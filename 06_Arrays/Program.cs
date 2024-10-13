using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //DeğişkenTürü [] DiziAdı = new DeğişkenTürü[ElemanSayısı]
            //string[] colors = new string[4];
            //colors[0] = "sarı";
            //colors[1] = "kırmızı";
            //colors[2] = "yeşil";
            //colors[3] = "beyaz";
            //Console.Write("Lütfen takım adı giriniz: ");
            //string takim = Console.ReadLine();
            //if (takim == "galatasaray")
            //{
            //    Console.WriteLine(colors[0] +" "+ colors[1]);
            //}

            //Console.WriteLine(colors[0]);

            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";
            //Console.WriteLine(cities[2]);

            //int[] numbers =new int[10];
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;
            //numbers[9] = 4;
            //numbers[6] = 5;
            //Console.WriteLine(numbers[9]);

            //string[] cities = { "Ankara", "Şanlıurfa", "İzmir", "Konya" };
            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "sarı", "kırmızı", "beyaz", "turuncu", "yeşil", "beyaz", "mavi" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 565, 45, 34, 78, 997, 1434, 5675, 33, 21, 23 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}

            //char[] chars = { 'a', 'b', 'c', 'd', 'e', '*', '/' };

            //for (int i = 0; i < chars.Length; i++)
            //{
            //    Console.WriteLine(chars[i]);
            //}

            //int[] myArray = { 12, 34, 64, 32, 87, 53, 972, 44, 77, 55, 175 };

            //int maxnumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxnumber)
            //    {
            //        maxnumber = myArray[i];
            //    }
            //}
            //Console.WriteLine("En büyük değer: " + maxnumber);
            #endregion

            #region Dizi Metodları
            //string[] persons = { "özlem", "ahmet", "elif", "yaren", "enes", "mahmut", "mehmet", "ayşe" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 23, 445, 76, 98, 43, 99, 76 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //diziyi tersten sıralar
            //int[] numbers = { 23, 445, 76, 98, 43, 99, 76 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //string[] customers = { "ali", "merve", "talha", "muhammed", "ayşe", "kaya" };
            //int index = Array.IndexOf(customers, "kaya");
            //Console.WriteLine(index);

            //int[] numbers = { 3, 567, 87, 44, 35, 807, 544, 965, 534 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() +
            //    " Dizinin en küçük elemanı: " + numbers.Min() +
            //    " Dizinin boyutu: " + numbers.Length);

            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1}. Şehri giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("---------------");
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //klavyeden girilen 5 sayılık dizi toplama
            //int[] numbers = new int[5];
            //int toplam = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"Lütfen {i + 1}. Sayıyı Giriniz ");
            //    numbers[i] = Convert.ToInt16(Console.ReadLine());
            //    toplam += numbers[i];
            //}
            //Console.WriteLine("Toplam: " + toplam); 

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Console.WriteLine("Çift Sayılar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine("------------");
            //Console.WriteLine("Tek Sayılar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion

            Console.Read();
        }
    }
}
