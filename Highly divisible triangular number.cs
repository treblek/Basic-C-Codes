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
            int sayi=0,donguDegiskeni=0,bolenSayisi=0;
            for(int j= 1; j<=999999999;j++)
            {

                sayi = j;
                while (donguDegiskeni != sayi)
                {
                    for (int i = 1; i <= sayi; i++)
                    {
                        if (sayi % i == 0)
                        {
                            bolenSayisi++;
                        }
                        if (bolenSayisi >= 500)
                        {
                            Console.WriteLine("{0}", sayi);
                            Console.ReadLine();
                        }
                    }
                    
                    
                    bolenSayisi = 0;
                    donguDegiskeni++;
                }
            }
        }
    }
}
