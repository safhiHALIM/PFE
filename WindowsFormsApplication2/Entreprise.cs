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
    
    public partial class Entreprise
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Entreprise()
        {
            this.Contrat = new HashSet<Contrat>();
        }
    
        public int N_siret { get; set; }
        public string Nom_de_société { get; set; }
        public string forme_jurdique { get; set; }
        public string Code_naf { get; set; }
        public string Secteur_d_activité { get; set; }
        public Nullable<int> Nombre_de_salariés { get; set; }
        public string Chiffre_d_affaires { get; set; }
        public string Adresse { get; set; }
        public Nullable<int> Code_postale { get; set; }
        public string Ville { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contrat> Contrat { get; set; }
    }
}
