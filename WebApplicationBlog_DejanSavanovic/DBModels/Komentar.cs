//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplicationBlog_DejanSavanovic.DBModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class Komentar
    {
        public int KomentarId { get; set; }
        public int KorisnikId { get; set; }
        public int BlogId { get; set; }
        public string Sadrzaj { get; set; }
        public System.DateTime DatumKreiranja { get; set; }
    
        public virtual Blog Blog { get; set; }
        public virtual Korisnik Korisnik { get; set; }
    }
}
