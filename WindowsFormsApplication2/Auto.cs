//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Auto
    {
        public string Immatriculation { get; set; }
        public string CIN { get; set; }
        public string usage_de_véhicule { get; set; }
        public Nullable<int> kilométrage_annuel { get; set; }
        public string Marque_de_véhicule { get; set; }
        public string Modéle_de_véhicule { get; set; }
        public string Puissance_fiscale { get; set; }
        public Nullable<int> Nombre_de_sinistre { get; set; }
        public string Nombre_de_mois { get; set; }
        public Nullable<System.DateTime> date_début { get; set; }
    
        public virtual Client Client { get; set; }
    }
}
