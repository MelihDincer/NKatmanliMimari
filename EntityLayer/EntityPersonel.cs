using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
       public class EntityPersonel
    {
        //ESKİ KULLANIM -Full Property

        //private int id;
        //private string ad;
        //private string soyad;
        //private string sehir;
        //private string gorev;
        //private short maas;

        //public int Id { get => id; set => id = value; }
        //public string Ad { get => ad; set => ad = value; }
        //public string Soyad { get => soyad; set => soyad = value; }
        //public string Sehir { get => sehir; set => sehir = value; }
        //public string Gorev { get => gorev; set => gorev = value; }
        //public short Maas { get => maas; set => maas = value; }


        //YENİ KULLANIM - Prop Property
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Sehir { get; set; }
        public string Gorev { get; set; }
        public short Maas { get; set; }
    }
}
