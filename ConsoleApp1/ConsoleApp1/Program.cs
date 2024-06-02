using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Разработайте приложение, которое будет находить минимальное и
//максимальное значение в двумерном массиве

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int rows = 2; 
            int columns = 3;
            int[,] arr2D = new int[rows, columns]; 

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    arr2D[i, j] = r.Next(-10, 10);
                    Console.Write($"{arr2D[i, j]} \t");
                }
                Console.WriteLine(); 
            }

            int MAXvalue = arr2D[0, 0];
            int MINvalue = arr2D[0, 0];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (arr2D[i, j] > MAXvalue)
                    {
                        MAXvalue = arr2D[i, j];
                    }
                    if (arr2D[i, j] < MINvalue)
                    {
                        MINvalue = arr2D[i, j];
                    }
                }
            }

            Console.WriteLine("MINvalue: " + MINvalue + "\nMAXvalue: " + MAXvalue);
            Console.ReadKey();
        }

    }
}
