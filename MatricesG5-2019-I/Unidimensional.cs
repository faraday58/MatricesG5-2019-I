using System;

namespace MatricesG5_2019_I
{
    class Unidimensional : Matriz
    {
        private float[] matriz;

        public Unidimensional(byte N)
        {
            this.N = N;

            matriz = new float[N];

        }

        public static Unidimensional Leer(string matriz)
        {
            //Ejemplo: 1 2 3 4
            string[] columnas = matriz.Split(' ');
            Unidimensional matrizunidimensional = new Unidimensional((byte)columnas.Length);
            for (int i = 0; i < matrizunidimensional.N ; i++  )
            {
                matrizunidimensional.matriz[i] = float.Parse(columnas[i]);
            }

            return matrizunidimensional;

        }

        public static Unidimensional operator +(Unidimensional m1,Unidimensional m2  )
        {
            Unidimensional m3 = new Unidimensional(m1.N);

            for( int i=0; i < m3.N; i++)
            {
                m3.matriz[i] = m1.matriz[i] + m2.matriz[i];
            }

            return m3;
        }





        public override string ToString()
        {
            //1 2 3 4
            string aux = "";
            for(int i= 0; i < N; i++  )
            {
                aux = aux + " " + matriz[i].ToString();
            }

            return aux;
        }

    }
}
