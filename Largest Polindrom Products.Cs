using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int birinciDegisken=0;
            for(int i =100;i<=999;i++)
            {
                for(int j=100;j<=999;j++)
                {
                    if (i * j == (tersCevir(i * j)) && i * j > birinciDegisken) 
                    {
                        birinciDegisken = i * j;
                    }
                }
            }
            Console.WriteLine("{0}", birinciDegisken);
            Console.ReadLine();
        }
        static int tersCevir(int gonderilenSayi)
        {
            int birinciDegisken=0,basamakSayisi = basamakSayisiHesapla(gonderilenSayi);
            for(int i =basamakSayisi-1;i>=0;i--)
            {
                birinciDegisken += (gonderilenSayi % 10)*ustAl(10,i);
                gonderilenSayi /= 10;
            }
            return birinciDegisken;
        }
        static int basamakSayisiHesapla(int gonderilenSayi)
        {
            int birinciDegisken=0;
            while(gonderilenSayi>0)
            {
                birinciDegisken++;
                gonderilenSayi /= 10;
            }
            return birinciDegisken;
        }
        static int ustAl(int gonderilenSayi,int ust)
        {
            int birinciDegisken=1;
            for(int i = 0;i<ust; i++)
            {
                birinciDegisken *= gonderilenSayi; 
            }
            return birinciDegisken;
        }
    }
}
