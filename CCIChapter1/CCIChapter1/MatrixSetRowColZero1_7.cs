using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCIChapter1
{
    class MatrixSetRowColZero1_7
    {
        static void SetRowColZero(int[,] mat)
        {
            int[] row = new int[mat.GetLength(0)];
            int[] col = new int[mat.GetLength(1)];
            printMatrix(mat);
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] == 0)
                    {
                        row[i] = 1;
                        col[j] = 1;
                    }
                }
            }

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (row[i] == 1 || col[j] == 1)
                    {
                        mat[i, j] = 0;
                    }
                }
            }

            printMatrix(mat);
        }

        static void printMatrix(int[,] mat)
        {
            Console.WriteLine("Matrix: ");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write("{0} ", mat[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static void driver()
        {
            int[,] mat = { 
                         {1, 2, 3, 4, 5},
                         {6, 7, 8, 0, 9},
                         {1, 1, 2, 3, 2},
                         {4, 0, 9, 7, 9}
                         };

            SetRowColZero(mat);
        }
    }
}
