using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _130731Win_PizzaOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmBoxEbat.Items.Add(new PizzaEbat { Adi = "Küçük Boy", Carpan = 1 });
            cmBoxEbat.Items.Add(new PizzaEbat { Adi = "Orta Boy", Carpan = 1.5m });
            cmBoxEbat.Items.Add(new PizzaEbat { Adi = "Büyük Boy", Carpan = 2 });
            cmBoxEbat.Items.Add(new PizzaEbat { Adi = "Maksi Boy", Carpan = 2.5m });
            lstBoxTuru.Items.Add(new PizzaTuru { Adi = "Klasik", Fiyat = 11 });
            lstBoxTuru.Items.Add(new PizzaTuru { Adi = "Karışık", Fiyat = 15 });
            lstBoxTuru.Items.Add(new PizzaTuru { Adi = "İtalyan Pizza", Fiyat = 16 });
            lstBoxTuru.Items.Add(new PizzaTuru { Adi = "Turkish Pizza", Fiyat = 14 });
            lstBoxTuru.Items.Add(new PizzaTuru { Adi = "Extravaganza", Fiyat = 18 });
            rdBtnInceK.Tag = new PizzaKenar { Adi = "Ince Kenar", KenarFiyat = 1 };
            rdBtnKalinK.Tag = new PizzaKenar { Adi = "Kalin Kenar", KenarFiyat = 1.5m };
            foreach (CheckBox item in grpBoxMalzemeler.Controls)
            {
                item.Tag = new PizzaMalzeme { Adi = item.Text, EkFiyat = 0.25m };
            }

        }

        Siparis SiparisHesapla() 
        {
            Pizza p=new Pizza();
            Siparis s=new Siparis();
            s.Adet=(int)nmrcAdet.Value;
            p.Ebat = (PizzaEbat)cmBoxEbat.SelectedItem;
            p.Turu = (PizzaTuru)lstBoxTuru.SelectedItem;
            if (rdBtnKalinK.Checked)
            {
                p.KenarTuru = (PizzaKenar)rdBtnKalinK.Tag;
            }
            else
            {
                p.KenarTuru = (PizzaKenar)rdBtnInceK.Tag;
            }

            foreach (CheckBox item in grpBoxMalzemeler.Controls)
            {
                p.Malzemeler.Add((PizzaMalzeme)item.Tag);
            }
            s.Pizza = p;
            return s;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Siparis sip = SiparisHesapla();
            txtTutar.Text = sip.Fiyat.ToString("C");
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            Siparis sip = SiparisHesapla();
            ListViewItem sipEkle = new ListViewItem();
            sipEkle.Text = cmBoxEbat.SelectedItem.ToString();
            sipEkle.SubItems.Add(lstBoxTuru.SelectedItem.ToString());
            if (rdBtnKalinK.Checked)
            {
                sipEkle.SubItems.Add(rdBtnKalinK.Text);
            }
            else
            {
                sipEkle.SubItems.Add(rdBtnInceK.Text);
            }
            string malzemeler = "";
            foreach (CheckBox item in grpBoxMalzemeler.Controls)
            {

                if (item.Checked)
                {
                    malzemeler += item.Text + "-"; 
                }
                
            }
            sipEkle.SubItems.Add(malzemeler);
            sipEkle.SubItems.Add(sip.Adet.ToString());
            sipEkle.SubItems.Add(sip.Fiyat.ToString("C"));
            listView1.Items.Add(sipEkle);
        }


        Sepet sep = new Sepet();

        private void btnSipOnayla_Click(object sender, EventArgs e)
        {

            Siparis sip = SiparisHesapla();
            sep.Siparisler.Add(sip);
            lblTopTutar.Text = sep.ToplamFiyat.ToString("C");
        }
    }
}
