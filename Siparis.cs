using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _130731Win_PizzaOtomasyonu
{
    
    public class Siparis
    {
        public Pizza Pizza { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat
        {
            get
            {
                return Pizza.Fiyat * Adet;
            }
        }

        public override string ToString()
        {
            return Pizza.ToString();
        }
    }
}
