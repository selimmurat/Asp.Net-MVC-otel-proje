//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Otel.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bilgilendirme
    {
        public int bilgiID { get; set; }
        public string adSoyad { get; set; }
        public string telefon { get; set; }
        public Nullable<int> odaTur { get; set; }
        public Nullable<System.DateTime> istekTarihi { get; set; }
        public string cevap { get; set; }
        public Nullable<System.DateTime> cevapTarihi { get; set; }
        public string ePosta { get; set; }
        public string mesaj { get; set; }
    
        public virtual OdaTur OdaTur1 { get; set; }
    }
}
