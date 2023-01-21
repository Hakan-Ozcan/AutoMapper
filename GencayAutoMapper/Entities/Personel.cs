using System.Collections.Generic;

namespace GencayAutoMapper.Entities
{
    public class Personel
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        virtual public ICollection<Musteri> Musteriler { get; set; }
        virtual public ICollection<Satis> Satislar { get; set; }
    }
}
