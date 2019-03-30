using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OtelReservasyonUygulamasi
{
    class Otel
    {
        private static int oda_sayisi = 20;
        private Oda[] odalar;

        public Otel()
        {
            odalar = new Oda[oda_sayisi];
            odalari_olustur();
        }

        private void odalari_olustur()
        {
            int n = 0;
            for(int i = 1; i <= 5; i++) //5 kat her kat 4 oda
            {
                for(int j = 1; j<= 4; j++)
                {
                    if (j <= 2)
                    {
                        odalar[n] = new TekYatakliOda(i * 100 + j);
                    }
                    else if(j<= 3)
                    {
                        odalar[n] = new CiftYatakliOda(i * 100 + j);
                    }
                    else
                    {
                        odalar[n] = new IkizYatakliOda(i * 100 + j);
                    }
                    n++;
                }
            }
        }

        public Oda getIndexOf(int i)
        {
            return odalar[i];
        }
    }
}
