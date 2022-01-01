using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje1
{
   public  class Isci
    {
        public long Kimlik_no { get; set; }
        public decimal Asgari_gecim_indirimi { get;private  set; }
        public short Cocuk_sayisi{ get; private  set; }
        public decimal Maas { get; set; }
        public Isci(short cocuk,decimal maas)
        {
            this.Cocuk_sayisi = cocuk;
            this.Maas = maas;
            Asgari_gecim_indirimi_hesapla();
            Maas_hesapla();
        }
       
        private void Asgari_gecim_indirimi_hesapla()
        {
            if (Cocuk_sayisi >= 1)
            {
                Asgari_gecim_indirimi = 105M;
            }
            else
            {
                Asgari_gecim_indirimi = 80M;
            }
        }
        private void Maas_hesapla()
        {
            if (Cocuk_sayisi >= 1)
            {
                Maas = Maas + Asgari_gecim_indirimi;
            }
           
            else
            {
                Maas = Maas + Asgari_gecim_indirimi;
            }
        }
    }
}
