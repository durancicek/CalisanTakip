using CalisanTakipBLL.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalisanTakipWebUI.Controllers
{
    public class IzinTipiController : Controller
    {
        private readonly IIzinTipiService _izinTipiService;
        public IzinTipiController(IIzinTipiService izinTipiService)
        {
            _izinTipiService = izinTipiService;
        }

        public IActionResult Index()
        {
           
            return View();
        }
    }
}
