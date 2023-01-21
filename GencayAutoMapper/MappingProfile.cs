using AutoMapper;
using GencayAutoMapper.Entities;
using GencayAutoMapper.ViewModels;

namespace GencayAutoMapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Personel, VMPersonel>();
            CreateMap<VMPersonel, Personel>();
            CreateMap<Musteri, VMMusteri>();
            CreateMap<VMMusteri, Musteri>();
            CreateMap<Satis, VMSatis>();
            CreateMap<VMSatis, Satis>();
        }
    }
}
