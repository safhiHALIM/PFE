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
    
    public partial class Accident
    {
        public string Code_Accident { get; set; }
        public string Lieu_d_accident { get; set; }
        public Nullable<System.DateTime> Date_Accident { get; set; }
        public string Description { get; set; }
        public string ID_risques { get; set; }
        public string Code_expert { get; set; }
    
        public virtual Expert Expert { get; set; }
        public virtual Risque_diver Risque_diver { get; set; }
    }
}