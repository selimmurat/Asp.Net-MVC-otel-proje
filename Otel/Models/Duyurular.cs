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
    
    public partial class Duyurular
    {
        public int duyuruID { get; set; }
        public string duyuruBaslik { get; set; }
        public string duyuruDetay { get; set; }
        public Nullable<System.DateTime> duyuruTarih { get; set; }
        public Nullable<System.DateTime> yayinTarih { get; set; }
    }
}