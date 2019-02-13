using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int sonuc=0;
            for (int i =1;i<10000;i++)
            {
                if ( i== bolenHesapla(bolenHesapla(i)))
                {
                    if (i < bolenHesapla(i))
                    {
                        sonuc += i+bolenHesapla(i);
                    }
                }
            }
            Console.WriteLine(sonuc);
            Console.ReadLine();
        }

        static int bolenHesapla(int gonderilenSayi)
        {
            int sonuc=0;
            for(int i =1;i<gonderilenSayi;i++)
            {
                if(gonderilenSayi%i==0)
                {
                    sonuc += i;
                }
            }
            return sonuc;
        }
    }
}
