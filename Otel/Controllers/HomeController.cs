using Otel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Otel.Controllers
{
    public class HomeController : Controller
    {
        OtelEntities ent = new OtelEntities();

        public ActionResult Index()
        {

            AnaSayfaDTO obj = new AnaSayfaDTO();
            obj.slider = ent.Slider.Where(x => (x.baslangicTarihi <= DateTime.Now && x.bitisTarihi > DateTime.Now)).ToList();


            obj.gorusler = ent.MusteriGorus.ToList();

            return View(obj);
        }

        public ActionResult TumOdalar()
        {
            return View();
        }

        public ActionResult TekKisilikOda()
        {
            return View();
        }

        public ActionResult CiftKisilikOda()
        {
            return View();
        }

        public ActionResult SuitRoom()
        {
            return View();
        }

        public ActionResult Galeri()
        {
            return View();
        }

        public ActionResult iletisim()
        {
            AnaSayfaDTO objBilgi = new AnaSayfaDTO();
            ViewBag.TercihOda = new SelectList(ent.OdaTur.OrderBy(x => x.turAdi).ToList(),"turAdi","turAdi");
            return View("iletisim");
        }

        [HttpPost]
        public ActionResult BilgiIstekFormuGonder(AnaSayfaDTO blgform)
        {
            try
            {
                Bilgilendirme _bilgiform = new Bilgilendirme();
                _bilgiform.adSoyad = blgform.bilgiformu.adSoyad;
                _bilgiform.telefon = blgform.bilgiformu.telefon;
                _bilgiform.ePosta = blgform.bilgiformu.ePosta;
                _bilgiform.odaTur = blgform.bilgiformu.odaTur;
                _bilgiform.istekTarihi = DateTime.Now;
                ent.Bilgilendirme.Add(_bilgiform);
                ent.SaveChanges();
                TempData["Mesaj"] = "Form Başarıyla gönderilmiştir.";
                return iletisim();
            }
            catch (Exception ex)
            {
                throw new Exception("Eklerken hata oluştu");
            }
        }
    }
}