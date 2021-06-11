using Otel.Models;
using System.Collections.Generic;

namespace Otel.Controllers
{
    public class AnaSayfaDTO
    {
        public List<Slider> slider { get; set; }
        public List<Duyurular> duyuru { get; set; }

        public Bilgilendirme bilgiformu { get; set; }
        public List<OdaTur> oda { get; set; }

        public List<MusteriGorus> gorusler { get; set; }
    }
}