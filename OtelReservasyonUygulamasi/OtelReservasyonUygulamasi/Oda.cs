﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelReservasyonUygulamasi
{
    abstract class Oda 
    {
        private int no; //oda numarası 101,102,...,405
        private int kapasite; //1 ya da 2

        private List<Rezervasyon> rezervasyonlar; //odaya ait rezervasyonlar

        public Oda(int no)
        {
            this.no = no;
            //kapasite alt class da atanıcak.
            rezervasyonlar = new List<Rezervasyon> { };
        }

        public int No
        {
            get
            {
                return no;
            }
        }

        //protected int Kapasite { set => kapasite = value; }

        protected int Kapasite
        {
            set
            {
                kapasite = value;
            }
        }
    }
}