using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OtelReservasyonUygulamasi
{
    class IkizYatakliOda: Oda
    {
        public IkizYatakliOda(int no) : base(no)
        {
            base.Kapasite = 2;
        }
    }
}
