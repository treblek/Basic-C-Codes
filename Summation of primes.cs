using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int donguDegiskeni;
            System.Int64 toplamDegiskeni =0;
            for (donguDegiskeni = 2; donguDegiskeni <= 2000000; donguDegiskeni++)
            {
                if (donguDegiskeni % 2 != 0 && donguDegiskeni % 2 != 0)
                {
                    if (asalKontrol(donguDegiskeni) == 1)
                    {
                        toplamDegiskeni += donguDegiskeni;
                        Console.WriteLine("{0}", donguDegiskeni);
                    }
                }
            }
            Console.WriteLine("{0}", toplamDegiskeni);
            Console.ReadLine();
        }

        static int asalKontrol(int gonderilenSayi)
        {
            int donguDegiskeni;
            for(donguDegiskeni=2;donguDegiskeni<=gonderilenSayi/2;donguDegiskeni++)
            {
                if(gonderilenSayi%donguDegiskeni==0)
                {
                    return 0;
                }
            }
            return 1;
        }
    }
}
