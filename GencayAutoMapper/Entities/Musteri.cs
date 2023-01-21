namespace GencayAutoMapper.Entities
{
    public class Musteri
    {
        
        public int Id { get; set; }
        public int PersonelId { get; set; }
        public string Adi { get; set; }
        public string Sirketi { get; set; }
        virtual public Personel Personel { get; set; }
    }
}

