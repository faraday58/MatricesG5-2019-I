using System;


namespace MatricesG5_2019_I
{
    class Multidimensional:Matriz
    {
        private float[,] matriz;

        public Multidimensional(byte M,byte N   )
        {
            this.M = M;
            this.N = N;

            matriz = new float[M, N];
         }

        public static Multidimensional Leer(string matriz )
        {
            //1 2 3;4 5 6;7 8 9
            string[] renglones = matriz.Split(';');
            string[] columnas = renglones[0].Split(' ');

            Multidimensional m1 = new Multidimensional((byte)renglones.Length,(byte)columnas.Length);

            for( int i=0; i < m1.M; i++)
            {
                columnas = renglones[i].Split(' ');
                for (int j=0; j < m1.N; j ++)
                {

                    m1.matriz[i, j] = float.Parse(columnas[j]);
                }
                
            }

            return m1;
        }

        public static Multidimensional operator +(Multidimensional mu1, Multidimensional mu2)
        {
            Multidimensional mu3 = new Multidimensional(mu1.M, mu1.N);

            for(int i = 0; i < mu3.M; i++  )
            {
                for(int j=0; j< mu3.N; j++ )
                {
                    mu3.matriz[i, j] = mu1.matriz[i, j] + mu2.matriz[i, j];
                }
            }
            return mu3;
        }


        public override string ToString()
        {
            //1 2 3
            //4 5 6
            //7 8 9
            string aux = "";
            for (int i=0; i < M; i ++)
            {
                for(int j=0; j  < N; j++)
                {
                    aux = aux + " " + matriz[i, j];
                }
                aux = aux + "\n";
            }

            return aux;
        }

    }
}
