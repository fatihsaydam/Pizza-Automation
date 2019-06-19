using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _130731Win_PizzaOtomasyonu
{
    public class PizzaMalzeme
    {
        public string Adi { get; set; }
        public decimal EkFiyat { get; set; }
        public override string ToString()
        {
            return Adi;
        }
   }
}
