using System;

namespace WinFormMatrizMulti_2026_I
{
    class Multidimensional:Matrix
    {
        private int[,] matrix;

        /// <summary>
        /// Constructor de la clase
        /// que inicializa el tamaño de la matriz
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        public Multidimensional(int m,int n)
        {
            M = m;
            N = n;
            matrix = new int[M, N];
        }

        public static Multidimensional Read(string matrix)
        {
            // 1,2;3,4  Cadena de texto

            //  1 2   Representacion de la matriz
            //  3 4

            string[] rows = matrix.Split(';'); // ["1,2","3,4"]
            string[] columns = rows[0].Split(','); // ["1","2"]





        }




    }
}
