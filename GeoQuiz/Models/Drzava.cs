//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GeoQuiz.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Drzava
    {
        public short SifraDrzava { get; set; }
        public byte SifraKontinent { get; set; }
        public string GlavniGrad { get; set; }
        public byte[] Zastava { get; set; }
        public Nullable<int> BrojStanovnika { get; set; }
        public string NazivDrzavaHr { get; set; }
        public string NazivDrzavaEng { get; set; }
    
        public virtual Kontinent Kontinent { get; set; }
    }
}
