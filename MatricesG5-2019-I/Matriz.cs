using System;

namespace MatricesG5_2019_I
{
    class Matriz
    {
        private byte n;
        private byte m;

        public byte N {
            get => n;
            set
            {
                if(value == 0 )
                {
                    n = 1;
                }
                else
                {
                    n = value;
                }
                

            }
                
        }
        public byte M {
            get => m;

            set
            {
                if (value == 0)
                    m = 1;
                else
                {
                    m = value;
                }
                    
                
            }
        }

        


    }
}
