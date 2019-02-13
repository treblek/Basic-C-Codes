using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[100000];
            int sonuc = 0;
            sayilar[0]=1; sayilar[1] =1;
            for (int i = 2; i <= 99999; i++)
            {
                sayilar[i] = sayilar[i - 1] + sayilar[i - 2];
                if (sayilar[i] < 4000000 && sayilar[i]%2==0)
                {
                    sonuc += sayilar[i];

                }
                if (sayilar[i] > 4000000) break;
            }
            Console.WriteLine(sonuc);
            Console.ReadLine();
        }
    }
}
