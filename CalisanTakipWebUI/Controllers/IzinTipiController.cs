using CalisanTakipBLL.Abstract;
using CalisanTakipCommon;
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
            var data = _izinTipiService.GetAllIzinTipi();
            if (data.IsSuccess) // Başarılı olursa view döndürülecek
            {
                var result = data.Data;
                return View(result);
            }

            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(IzinTipiVM model)
        {

            if (ModelState.IsValid)
            {
                var data = _izinTipiService.CreateIzinTipi(model);
                if (data.IsSuccess)
                {
                    return RedirectToAction("Index");
                }
                return View(model);
            }
            else
            {
                return View(model);
            }

        }

        public ActionResult Edit(int id)
        {
            if (id < 0)
                return View();

            var data = _izinTipiService.GetByIdIzinTipi(id);
            if (data.IsSuccess)
                return View(data.Data);
            return View();


        }


        [ValidateAntiForgeryToken] // Edit aksiyonu Get edilmeden Post edilemez.Js tarafından kodları tetikletmeyi engellemek için yazıldı.
        [HttpPost]
        public IActionResult Edit(IzinTipiVM model)
        {
            if (ModelState.IsValid)
            {
                var data = _izinTipiService.EditGetByIdIzinTipi(model);
                if (data.IsSuccess)
                {
                    return RedirectToAction("Index");
                }
                return View(model);

            }
            else
            {
                return View(model);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return Json(new { success = false, mesaj = "Silmek için Kayıt Seçiniz" });
            }
            else
            {
                
            }
            var data = _izinTipiService.RemoveIzinTipi(id);

            if (data.IsSuccess)
                return Json(new { success = data.IsSuccess, mesaj = data.Mesaj });
            else
                return Json(new { success = data.IsSuccess, mesaj = data.Mesaj });

        }


    }
}
