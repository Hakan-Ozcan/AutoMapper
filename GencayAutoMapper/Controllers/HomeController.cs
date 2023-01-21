using AutoMapper;
using GencayAutoMapper.Entities;
using GencayAutoMapper.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GencayAutoMapper.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMapper _mapper;
        public HomeController(IMapper mapper)
        {
            _mapper= mapper;
        }

        [HttpPost]
        public ActionResult Create(VMPersonel model)
        {
            Personel personel = _mapper.Map<Personel>(model);
            return View();
        }
    }
}
