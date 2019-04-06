using System;
using System.Collections.Generic;

namespace OtelRezervasyonUygulamasi
{
    internal abstract class Oda
    {
        private int no; //oda numarası 101,102,...,504
        private int kapasite; //1 ya da 2
        private List<Rezervasyon> rezervasyonlar; //odaya ait rezervasyonlar

        public Oda(int no)
        {
            this.no = no;
            //kapasite alt class da atanıcak.
            rezervasyonlar = new List<Rezervasyon> { };
        }

        public List<Rezervasyon> Rezervasyonlar
        {
            get
            {
                return rezervasyonlar;
            }
        }

        public int No
        {
            get
            {
                return no;
            }
        }

        protected int Kapasite
        {
            set
            {
                kapasite = value;
            }
        }

        public abstract string getName();

        public int rezervasyonYap(Rezervasyon rezervasyon)
        {
            bool yapilabilirMi = true;

            foreach (Rezervasyon r in rezervasyonlar)
            {
                if (rezervasyon.Bitis_Tarihi > r.Baslangic_Tarihi && rezervasyon.Baslangic_Tarihi < r.Bitis_Tarihi)
                {
                    yapilabilirMi = false;
                    break;
                }
                //yapılacak rezervasyonun odadaki bir rezervasyonla tarihleri çakışıyor
            }

            if (yapilabilirMi == true)
            {
                rezervasyonlar.Add(rezervasyon);
                return this.no; //rezervasyonun yapıldığı oda no döndürülüyor
            }
            else
            {
                return 0;
            }
        }

        public Boolean rezervasyonIptal(int rez_no)
        {
            foreach (Rezervasyon rez in rezervasyonlar)
            {
                if (rez.No == rez_no)
                {
                    rezervasyonlar.Remove(rez);
                    return true;
                }
            }
            return false;
        }

    }
}