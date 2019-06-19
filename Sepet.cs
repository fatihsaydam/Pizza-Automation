using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _130731Win_PizzaOtomasyonu
{
    public class Sepet
    {
        public Sepet()
        {
            Siparisler = new List<Siparis>();
        }
        public List<Siparis> Siparisler { get; set; }
        public decimal ToplamFiyat 
        {
            get
            {
                decimal total = 0;
                foreach (Siparis item in Siparisler)
                {
                    total += item.Fiyat;
                }
                return total;
            }
        }
       
    }
}
