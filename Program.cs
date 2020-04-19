using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for ( int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int n2 = 0;
            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < n; i++)
            {

                Console.Write(mat[i,i]+" ");
                for(int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        n2++;
                    }
                }

            }

            Console.WriteLine();
            Console.WriteLine("Negative numbers: "+n2);

        }
    }
}
