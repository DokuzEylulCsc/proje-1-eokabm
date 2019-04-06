using System;
using System.Collections.Generic;

namespace OtelReservasyonUygulamasi
{
    internal class Otel
    {
        private int oda_sayisi;
        private int toplam_kapasite;
        private Oda[] odalar;

        public int getKap()
        {
            return toplam_kapasite;
        }

        public Otel(int odaSayisi)
        {
            this.oda_sayisi = odaSayisi;
            odalar = new Oda[oda_sayisi];
            toplam_kapasite = 0;
            odalari_olustur();            
        }

        public Oda[] Odalar
        {
            get
            {
                return odalar;
            }
        }

        private void odalari_olustur()
        {
            Random r = new Random();
            double rnd_number;
            int k = 1;

            for(int i = 0, j = 0; i < oda_sayisi; i++)
            {
                rnd_number = r.NextDouble();

                if (i % 10 == 0)//her kat 10 oda
                {
                    j++;
                    k = 1;
                }

                if(rnd_number < 0.40) //Tek yataklı oda oluşturulacak
                {
                    odalar[i] = new TekYatakliOda(j * 100 + k);
                    k++;
                    toplam_kapasite += 1;
                }
                else if(rnd_number < 0.75) //Çift yataklı oda oluşturulacak
                {
                    odalar[i] = new CiftYatakliOda(j * 100 + k);
                    k++;
                    toplam_kapasite += 2;
                }
                else //İkiz yataklı oda oluşturulacak
                {
                    odalar[i] = new IkizYatakliOda(j * 100 + k);
                    k++;
                    toplam_kapasite += 2;
                }

            }

        }

        public int rezervasyonYap(Rezervasyon rezervasyon, Type tip)
        {
            int kontrol = 0;

            foreach(Oda o in Odalar)
            {
                if (o.GetType() != tip) continue;
                else
                {
                    kontrol = o.rezervasyonYap(rezervasyon);
                }
                if (kontrol != 0) break;
            }
            
            return kontrol;
        }

        public Boolean rezervasyonIptal(int rez_no) 
        {
            foreach (Oda oda in odalar)
            {
                foreach (Rezervasyon rez in oda.Rezervasyonlar)
                {
                    if (oda.rezervasyonIptal(rez_no))
                    {
                        return true;
                    }                
                }
            }
            return false;
        }
        
    }
}
