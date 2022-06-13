using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halk_Kitap
{
    public class Okuyucu
    {
        public Guid ID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Telefon { get; set; }
        public string Gmail { get; set; }
        public string Adres { get; set; }

        public override string ToString()
        {
            return $"{Adi} {Soyadi}";
        }

    }
    public class Kitap
    {
       public Guid ID { get; set; }
        public string ad { get; set; }
        public string kategori { get; set; }
        public double fiyat { get; set; }
        public double stok { get; set; }
        public string yazar { get; set; }
        public override string ToString()
        {
            return $"{ad} {yazar}";
        }

    }
    
     public class Ksatis
    {
        public Guid ID { get; set; }
        public Guid Okuyucuid { get; set; }
        public Guid Kitapid { get; set; }
        public Double Fiyat { get; set; }
        public DateTime Tarih { get; set; }
        
    }

    public class Ödeme

    {
        public Guid ID { get; set; }
        public Guid Okuyucuid { get; set; }
        public DateTime Tarih { get; set; }
        public double Fiyat { get; set; }
        public string Tur { get; set; }
        public string Acıklama { get; set; }
    }
}
