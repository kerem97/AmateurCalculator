using System;

namespace ConsoleApp76
{
    class Program
    {

        static int topla(int s1,int s2)
        {
            Console.Write("Sayı girin:");
           s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sayı girin:");
           s2 = Convert.ToInt32(Console.ReadLine());
            int tpl = 0;
            tpl = s1 + s2;
            return tpl;

        }
        static int carp(int s1, int s2)
        {
            Console.Write("Sayı girin:");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sayı girin:");
            s2 = Convert.ToInt32(Console.ReadLine());
            int tpl = 0;
            tpl = s1 * s2;
            return tpl;
        }
        static int böl(int s1, int s2)
        {
            Console.Write("Sayı girin:");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sayı girin:");
            s2 = Convert.ToInt32(Console.ReadLine());
            int tpl = 0;
            tpl = s1 / s2;
            return tpl;
        }
        static int cıkar(int s1, int s2)
        {
            Console.Write("Sayı girin:");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sayı girin:");
            s2 = Convert.ToInt32(Console.ReadLine());
            int tpl = 0;
            tpl = s1 - s2;
            return tpl;
        }
        static void Main(string[] args)
        {

                int islem;
            Console.Write("***** Toplama için 1 , Çarpma için 2 , Bölme için 3 , Çıkarma için 4 ******");
            Console.WriteLine();
            Console.Write("İslem numarasını seçiniz :");
                islem = Convert.ToInt32(Console.ReadLine());
                
                if (islem == 1)
                {
                    int sonuc = topla(0,0);
                    Console.Write("Toplama sonucu = " + sonuc);
                }
                else if (islem == 2)
                {
                    int sonuc2 = carp(0,0);
                    Console.Write("Carpma sonucu = " + sonuc2);
                }
            else if (islem == 3)
            {
                int sonuc2 = böl(0, 0);
                Console.Write("Bölme sonucu = " + sonuc2);
            }
            else if (islem == 4)
            {
                int sonuc2 = cıkar(0, 0);
                Console.Write("Cıkartma sonucu = " + sonuc2);
            }


            Console.ReadKey();
        }
    }
}
