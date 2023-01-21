namespace GencayAutoMapper.Entities
{
    public class Satis
    {
        public int Id { get; set; }
        public int PersonelId { get; set; }
        public string SatisNo { get; set; }
        virtual public Personel Personel { get; set; }
    }
}
