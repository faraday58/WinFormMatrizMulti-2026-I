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

            Multidimensional m1 = new Multidimensional(rows.Length, columns.Length);

            for (int i = 0; i < m1.M; i ++)
            {
                string[] values = rows[i].Split(','); // ["1","2"]
                for (int j = 0; j < m1.N; j++)
                {
                    m1.matrix[i, j] = int.Parse(values[j]);
                }
            }

            return m1;

        }


        public static Multidimensional operator + (Multidimensional m1, Multidimensional m2)
        {

            // 6 8     5 6
            // 10 12     7 8
            Multidimensional m3 = new Multidimensional(m1.M, m1.N);

            for (int i = 0; i < m1.M; i++)
            {
                for(int j = 0; j < m1.N; j++)
                {
                    m3.matrix[i,j] = m1.matrix[i, j] + m2.matrix[i, j];
                }

            }
            return m3;

        }



        public override string ToString()
        {
            // 1 2
            // 3 4

            string matrix = "";

            for (int i = 0; i < this.M; i++)
            {
                for (int j = 0; j < this.N; j++)  
                {
                    matrix += this.matrix[i, j] + "\t"; 
                }
                matrix += "\n";
            }


            return matrix; 

        }




    }
}
