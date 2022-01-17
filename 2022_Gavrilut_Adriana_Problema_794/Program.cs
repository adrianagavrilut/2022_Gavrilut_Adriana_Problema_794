using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_Gavrilut_Adriana_Problema_794
{
    class Program
    {
        static void Main(string[] args)
        {
            string pl = Console.ReadLine();
            int n = int.Parse(pl);
            int[,] a = new int[n, n];
            string buffer;
            for (int i = 0; i < n; i++)
            {
                buffer = Console.ReadLine();
                string[] local = buffer.Split(' ');
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(local[j]);
                }
            }
            Console.WriteLine();
            int dir = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (dir == 0)
                    {
                        Console.Write(a[j, i - 1 - j] + " ");
                    }
                    else
                    {
                        Console.Write(a[i - 1 - j, j] + " ");
                    }
                }
                dir = 1 - dir;
            }
            for (int i = 1; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (dir == 0)
                    {
                        Console.Write(a[j, n + i - 1 - j] + " ");
                    }
                    else
                    {
                        Console.Write(a[n + i - 1 - j, j] + " ");
                    }
                }
                dir = 1 - dir;
            }
        }
    }
}
