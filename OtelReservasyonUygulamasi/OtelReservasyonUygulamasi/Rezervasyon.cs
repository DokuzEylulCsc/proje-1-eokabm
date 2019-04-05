using System;

namespace OtelReservasyonUygulamasi
{
    class Rezervasyon
    {
        private int no;
        private int kisi_sayisi;
        private DateTime baslangic_tarihi;
        private DateTime bitis_tarihi;
        private static int rez_no = 0;

        public Rezervasyon(int kisiSayisi, DateTime basTar, DateTime bitTar)
        {
            rez_no++;
            this.no = rez_no;
            this.kisi_sayisi = kisiSayisi;
            this.baslangic_tarihi = basTar;
            this.bitis_tarihi = bitTar;
        }

        public int No
        {
            get
            {
                return no;
            }
        }
       
        public int Kisi_sayisi
        {
            get
            {
                return kisi_sayisi;
            }
        }

        public DateTime Baslangic_Tarihi
        {
            get
            {
                return baslangic_tarihi;
            }
        }

        public DateTime Bitis_Tarihi
        {
            get
            {
                return bitis_tarihi;
            }
        }
        
    }
}
