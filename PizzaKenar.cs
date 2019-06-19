using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _130731Win_PizzaOtomasyonu
{
    public class PizzaKenar
    {
        public string Adi { get; set; }
        public decimal KenarFiyat { get; set; }
        public override string ToString()
        {
            return Adi;
        }
    }
}
