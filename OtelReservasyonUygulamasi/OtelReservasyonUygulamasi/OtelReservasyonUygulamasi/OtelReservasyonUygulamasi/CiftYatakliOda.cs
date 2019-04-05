using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OtelReservasyonUygulamasi
{
    class CiftYatakliOda: Oda
    {
        public CiftYatakliOda(int no) : base(no)
        {
            base.Kapasite = 2;
        }
    }
}
