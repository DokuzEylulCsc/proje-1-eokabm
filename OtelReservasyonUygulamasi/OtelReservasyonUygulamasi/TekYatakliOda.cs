﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OtelReservasyonUygulamasi
{
    class TekYatakliOda: Oda
    {
        public TekYatakliOda(int no) : base(no)
        {
            base.Kapasite = 1;
        }
    }
}