
namespace WinFormMatrizMulti_2026_I
{
    class Matrix
    {
        #region Atributes
        private int m;
        private int n;
        #endregion


        #region Properties
        public int M { get => m;

            set
            {
                if(value <= 0)
                {
                    m = 1;
                }
                else
                {
                    m = value;
                }
                    
            }
        }
        public int N { 
            get => n;
            set
            {
                if(value <= 0)
                {
                    n = 1;
                }
                else
                {
                    n = value;
                }

                    
            }
        }
        #endregion

    }
}
