using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Array2D = new int[2, 3];
            Console.Write("Enter a 2D Array:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Array2D[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int index = 0;
          
            int NoOfRows = Array2D.GetLength(0);         
            int NoOfColumns = Array2D.GetLength(1);
            int[] Array1D = new int[NoOfRows * NoOfColumns];


            for (int y = 0; y < NoOfColumns; y++)
            {
                for (int x = 0; x < NoOfRows; x++)
                {
                    Array1D[index] = Array2D[x, y];
                    index++;
                }
            }

            Console.WriteLine("1D Array :");
            foreach (int item in Array1D)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
