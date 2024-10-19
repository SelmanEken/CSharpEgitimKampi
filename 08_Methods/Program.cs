using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //()
            //geriye değer döndürmeyen metotlar
            //void

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x+y;
            //    Console.WriteLine(z);
            //}

            //Sum();


            #endregion

            #region Geriye değer döndürmeyen string parametreli metotlar

            //void WriteMethod (string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet Yıldırım");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}

            //CustomerCard("Mehmet","Yıldız");
            //CustomerCard("Ayşegül","Kaya");


            #endregion

            #region Geriye değer döndürmeyen ınt parametreli metotlar

            //void Sum(int number1,int number2,int number3)
            //{
            //    int result = number1 + number2+number3;
            //    Console.WriteLine(result);
            //}

            //Sum(3,2,4);

            #endregion

            #region Geriye değer döndüren metotlar

            //string CustumerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustumerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye değer döndüren string parametreli metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke adını giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak rengi giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            #endregion

            #region Geriye değer döndüren int parametreli metotlar

            //int Sum (int number1,int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(4,5));
            //Console.WriteLine(Sum(43,52));
            //Console.WriteLine(Sum(42,55));
            //Console.WriteLine(Sum(41,56));

            #endregion

            #region Örnek Uygulama
            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result > 50)
                {
                    return student + "isimli öğrenci sınavı geçti." + " Ortalama: " + result;
                }
                else
                {
                    return student + "isimli öğrenci sınavdan kaldı." + " Ortalama: " + result;
                }
            }

            Console.WriteLine(ExamResult("Ali", 55, 44, 33));
            Console.WriteLine(ExamResult("Ayşe", 55, 65, 33));

            #endregion


            Console.Read();
        }
    }
}
