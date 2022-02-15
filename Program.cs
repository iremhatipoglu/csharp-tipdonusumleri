using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipDonusumleriPatika
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Patika C# Modülü ders notları



            /********************************************************************************************************/



            //Implicit Conversiton 

            /* Bilinçli dönüşüm: Herhangi bir metod yazmadan bilgisayarın var olan veri tipinden daha kapsamlı
             * bir veri tipine dönüşüm yapması hali */


            /********************************************************************************************************/

            Console.WriteLine("***** Implicit Conversiton *****");


            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d: " + d);

            string s = "Irem";
            char h = 'T';

            object o = s + h + d; //tüm veri tipleri objectten türemiştir
            
            Console.WriteLine("o: " + o);


            /********************************************************************************************************/



            //Explicit Conversiton 

            /* Derleyiciye dönüşüm metodları yazılarak gerçekleştirilen dönüşüm işlemleridir */


            /********************************************************************************************************/

            Console.WriteLine("***** Explicit Conversiton *****");

            int x = 4;
            byte y = (byte)x;

            Console.WriteLine("y:" + y);

            //Dönüşümler yapılırken veri kaybı olabilir!


            /********************************************************************************************************/


            //ToString Metodu

            Console.WriteLine("***** ToString Metodu *****");

            string xx = 12.5f.ToString();
            Console.WriteLine("xx: " + xx);

            /********************************************************************************************************/


            //System.Convert 

            Console.WriteLine("***** System.Convert Sınıfı *****");

            string s1 = "20", s2 = "30";
            int sayi1, sayi2;
            

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            int toplam = sayi1 + sayi2;

            Console.WriteLine("Toplam: " + toplam);

            /********************************************************************************************************/


            //Parse Metodu

            Console.WriteLine("***** Parse Metodu *****");

            ParseMethod();

            
        }
        public static void ParseMethod(){

            string text1 = "10";
            string text2 = "10.25";
            int num1;
            double double1;

            num1 = Int32.Parse(text1);
            double1 = Double.Parse(text2);
            Console.WriteLine(num1);
            Console.WriteLine(double1);
        }
    }
}
