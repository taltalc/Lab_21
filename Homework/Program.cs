using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static  int n;
        static int m;
        static string[,] uchastok;

        static void Sadovnic1()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (uchastok[i,j]==null)
                    {
                        uchastok[i,j] = "Сад1";
                        Thread.Sleep(100);
                    }
                }
            }

            
        }
        static void Sadovnic2()
        {
            for (int i = n-1; i > 0; i--)           
            {
                for (int j = m-1; j > 0; j--)
                {
                    if (uchastok[j,i] == null)
                    {
                        uchastok[j,i] = "Сад2";
                        Thread.Sleep(100);

                    }
                }
            }

            
        }
        static void Main(string[] args)
        {
             
            m = (int)Convert.ToUInt32(Console.ReadLine());
             n = (int)Convert.ToInt32(Console.ReadLine());

            uchastok = new string[m, n];
            ThreadStart threadStart = new ThreadStart(Sadovnic1);
            Thread sad1 = new Thread(threadStart);
            ThreadStart threadStart1 = new ThreadStart(Sadovnic2);
            Thread sad2 = new Thread(threadStart1);
            
            sad1.Start();
            sad2.Start(); 
            sad1.Join();
            sad2.Join();
            
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(uchastok[i, j]+" ");
                }
                Console.WriteLine();
            }
            
            Console.ReadKey();
            

        }



    }
}
