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
            System.Int64 adimSayisi = 0,enBuyukAdim=0,adimdakiSayi=0,yedekDegisken=0;
            for(System.Int64 i=113382;i<=1000000;i++)
            {
                yedekDegisken = i;
                while (i!=1)
                {
                    if (i % 2 == 0)
                    {
                        i /= 2;
                        adimSayisi++;
                    }
                    else
                    {
                        i = i * 3 + 1;
                        adimSayisi++;
                    }
                }
               if(adimSayisi>enBuyukAdim)
                {
                    enBuyukAdim = adimSayisi;
                    adimdakiSayi = yedekDegisken;
                }
                adimSayisi = 0;
                i = yedekDegisken;
            }
            Console.WriteLine(adimdakiSayi);
            Console.ReadLine();
        }
    }
}
