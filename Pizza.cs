using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _130731Win_PizzaOtomasyonu
{
    public class Pizza
    {
        public Pizza()
        {
            Malzemeler = new List<PizzaMalzeme>();
        }
        public PizzaEbat Ebat { get; set; }
        public PizzaTuru Turu { get; set; }
        public PizzaKenar KenarTuru { get; set; }
        public List<PizzaMalzeme> Malzemeler { get; set; }
        public decimal Fiyat 
        {
            get
            {
                decimal fiyat = 0;
                fiyat += Turu.Fiyat;
                fiyat += KenarTuru.KenarFiyat;
                foreach (PizzaMalzeme malzeme in Malzemeler)
                {
                    fiyat += malzeme.EkFiyat;
                }
                fiyat *= Ebat.Carpan;
                return fiyat;

            }
        }

        public override string ToString()
        {
            string malzemeler = "";
            foreach (PizzaMalzeme item in Malzemeler)
            {
                malzemeler += item.Adi + "-";
            }
            return string.Format("{0},{1},{2},{3}", Ebat.Adi, Turu.Adi, KenarTuru.Adi, malzemeler);
        }
    }
}
