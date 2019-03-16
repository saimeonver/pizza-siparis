using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WindowsFormsApp3.Enums.Enum;

namespace WindowsFormsApp3
{
    class Bilgiler
    {
        
        public string Ad { get; set; }
        public string Adres { get; set; }
        public string Sehir { get; set; }

        public int PostaKodu { get; set; }


        private long telefon;

        public long Telefon
        {
            get { return telefon; }
            set
            {
                if (value.ToString().Length == 10   )
                {
                    telefon = value;

                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Eksik - Fazla  Numara Girişi || Numaranın Başına 0 Eklemeyiniz");
                }

            } 
        }
        public int qty { get; set; }
        public string KuponNumarasi { get; set; }
        public DateTime Tarih { get; set; } = DateTime.Now;
        
        
        public  OdemeSekli odemesekli
            { get; set;}
            

        public int KrediKartiNumarasi { get; set; }

        public string SonKullanmaTarihi { get; set; } 

            
    }
}
