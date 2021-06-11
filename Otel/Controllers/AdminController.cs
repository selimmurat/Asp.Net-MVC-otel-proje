using Otel.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Otel.Controllers
{
    public class AdminController : Controller
    {
        OtelEntities ent = new OtelEntities();

        #region // Slider

        public ActionResult Slider()
        {
            var slider = ent.Slider.ToList();
            return View(slider);
        }
        public ActionResult SlideEkle()
        {
            return View();
        }
        public ActionResult SlideDuzenle(int SlideID)
        {
            var _slideDuzenle = ent.Slider.Where(x => x.sliderID == SlideID).FirstOrDefault();
            return View(_slideDuzenle);
        }
        public ActionResult SlideSil(int SlideID)
        {
            try
            {
                ent.Slider.Remove(ent.Slider.First(d => d.sliderID == SlideID));
                ent.SaveChanges();
                return RedirectToAction("Slider", "Admin");
            }
            catch (Exception ex)
            {
                throw new Exception("Silerken hata oluştu", ex.InnerException);
            }
        }
        [HttpPost]
        public ActionResult SlideEkle(Slider s, HttpPostedFileBase file)
        {
            try
            {
                Slider _slide = new Slider();
                if (file != null && file.ContentLength > 0)
                {
                    MemoryStream memoryStream = file.InputStream as MemoryStream;
                    if (memoryStream == null)
                    {
                        memoryStream = new MemoryStream();
                        file.InputStream.CopyTo(memoryStream);
                    }
                    _slide.sliderFoto = memoryStream.ToArray();
                }
                _slide.sliderBaslik = s.sliderBaslik;
                _slide.sliderText = s.sliderText;
                _slide.baslangicTarihi = s.baslangicTarihi;
                _slide.bitisTarihi = s.bitisTarihi;
                ent.Slider.Add(_slide);
                ent.SaveChanges();
                return RedirectToAction("Slider", "Admin");
            }
            catch (Exception ex)
            {
                throw new Exception("Eklerken hata oluştu");
            }
        }
        [HttpPost]
        public ActionResult SlideDuzenle(Slider slide, HttpPostedFileBase file)
        {
            try
            {
                var _slideDuzenle = ent.Slider.Where(x => x.sliderID == slide.sliderID).FirstOrDefault();
                if (file != null && file.ContentLength > 0)
                {
                    MemoryStream memoryStream = file.InputStream as MemoryStream;
                    if (memoryStream == null)
                    {
                        memoryStream = new MemoryStream();
                        file.InputStream.CopyTo(memoryStream);
                    }
                    _slideDuzenle.sliderFoto = memoryStream.ToArray();
                }
                _slideDuzenle.sliderBaslik = slide.sliderBaslik;
                _slideDuzenle.sliderText = slide.sliderText;
                _slideDuzenle.baslangicTarihi = slide.baslangicTarihi;
                _slideDuzenle.bitisTarihi = slide.bitisTarihi;
                ent.SaveChanges();
                return RedirectToAction("Slider", "Admin");
            }
            catch (Exception ex)
            {
                throw new Exception("Güncellerken hata oluştu " + ex.Message);
            }

        }

        #endregion       

        #region // Bilgi Formu

        public ActionResult BilgiFormu()
        {
            var bilgiformu = ent.Bilgilendirme.ToList();
            return View(bilgiformu);
        }
        public ActionResult BilgiFormuDuzenle(int BilgiID)
        {
            var _bilgiDuzenle = ent.Bilgilendirme.Where(x => x.bilgiID == BilgiID).FirstOrDefault();
            return View(_bilgiDuzenle);
        }
        [HttpPost]
        public ActionResult BilgiFormuDuzenle(Bilgilendirme blg)
        {
            try
            {
                var _bilgiDuzenle = ent.Bilgilendirme.Where(x => x.bilgiID == blg.bilgiID).FirstOrDefault();
                _bilgiDuzenle.cevap = blg.cevap;
                _bilgiDuzenle.cevapTarihi = DateTime.Now;
                ent.SaveChanges();
                return RedirectToAction("BilgiFormu", "Admin");
            }
            catch (Exception ex)
            {
                throw new Exception("Güncellerken hata oluştu " + ex.Message);
            }

        }

        #endregion
    }
}