using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OtelReservasyonUygulamasi
{
    class tempClass
    {

        //denemeler yapılacak...

        public static void deneme()
        {
            Otel otel = new Otel();

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(otel.getIndexOf(i).No);
            }
        }
    }
}
