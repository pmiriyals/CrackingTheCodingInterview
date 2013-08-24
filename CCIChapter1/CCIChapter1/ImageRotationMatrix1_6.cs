using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCIChapter1
{
    class ImageRotationMatrix1_6
    {
        static void RotateImage(int[,] mat)
        {
            printMatrix(mat);

            for (int layer = 0; layer < mat.GetLength(0) / 2; layer++)
            {
                int first = layer;
                int last = mat.GetLength(0) - first - 1;

                for (int i = first; i < last; i++)
                {
                    int offset = i - first;
                    int top = mat[first, i];

                    mat[first, i] = mat[last - offset, first];

                    mat[last - offset, first] = mat[last, last - offset];

                    mat[last, last - offset] = mat[i, last];

                    mat[i, last] = top;
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
                    Console.Write("{0,2} ", mat[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static void driver()
        {
            int[,] mat = { 
                         {1, 2, 3, 4},
                         {5, 6, 7, 8},
                         {9, 10, 11, 12},
                         {13, 14, 15, 16}
                         };

            RotateImage(mat);
        }
    }
}
