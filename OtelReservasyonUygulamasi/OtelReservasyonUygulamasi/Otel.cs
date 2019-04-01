using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OtelReservasyonUygulamasi
{
    class Otel
    {
        private static int oda_sayisi = 20;
        public Oda[] odalar;

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

        public int rezervasyonYap(Rezervasyon rezervasyon, int hangiTip)
        {
            int kontrol = 0;
            
            if(hangiTip == 0) //tek yataklı odalar kontrol edilecek
            {
                foreach(Oda o in odalar)
                {
                    if (o.No % 100 == 1 || o.No % 100 == 2)
                    {
                        kontrol = o.rezervasyonYap(rezervasyon);
                    }
                    else
                    {
                        continue;
                    }
                    if (kontrol != 0) break; //rezervasyon yapıldı. oda no: kontrol
                }
            }
            else if(hangiTip == 1) //çift yataklı odalar kontrol edilecek
            {
                foreach (Oda o in odalar)
                {
                    if (o.No % 100 != 3 ) continue;
                    else
                    {
                        kontrol = o.rezervasyonYap(rezervasyon);
                    }
                    if (kontrol != 0) break; //rezervasyon yapıldı. oda no: kontrol
                }
            }
            else if(hangiTip == 2) //ikiz yataklı odalar kontrol edilecek
            {
                foreach (Oda o in odalar)
                {
                    if (o.No % 100 != 4) continue;
                    else
                    {
                        kontrol = o.rezervasyonYap(rezervasyon);
                    }
                    if (kontrol != 0) break; //rezervasyon yapıldı. oda no: kontrol
                }
            }

            return kontrol;
        }



    }
}
