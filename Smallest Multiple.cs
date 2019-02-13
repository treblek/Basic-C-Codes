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
            int[] sayilar = new int[20];

            for (int i = 0; i <= 19; i++)
            {
                sayilar[i] = i + 1;
            }



            int flag=0;
            for(int i =1;i<=1000000000;i++)
            {
                for(int j = 0;j<20;j++)
                {
                    if(i%sayilar[j]==0)
                    {
                        flag += 1;
                    }
                }
                if(flag == 20)
                {
                    Console.WriteLine("{0}", i);
                    Console.ReadLine();
                }
                else
                {
                    flag = 0;
                }
            }
        }
    }
}
