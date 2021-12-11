using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Homework2
{
    class Program
    {
        static int n;
        static int m;
        static int[,] uchastok;

        static void Main(string[] args)
        {
           
            m = (int)Convert.ToUInt32(Console.ReadLine());
            n = (int)Convert.ToInt32(Console.ReadLine());

            uchastok = new int[m-1, n-1];
            
            Thread sad1 = new Thread(Sadovnic1);
            sad1.Start();
            sad1.Join();
             
            for (int i = m-1; i>0; i--)
            {
                for (int j = n-1; j >0; j--)
                {
                    if (uchastok[i, j] == 0)
                    {
                        uchastok[i, j] = 1;
                    }
                    Console.WriteLine(uchastok[i, j]);
                }
            }
            Console.ReadKey();
        }

 
        static void Sadovnic1()
        {
            for (int i = 0; i <n; i++)
            {
                for (int j = 0; j <m; j++)
                {
                    if (uchastok[i, j] == 0)
                    {
                        uchastok[i, j] = 2;
                    }
                }
            }
            

        }
        
    }
}
