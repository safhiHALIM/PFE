﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class assuranceEntities1 : DbContext
    {
        public assuranceEntities1()
            : base("name=assuranceEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Accident> Accident { get; set; }
        public virtual DbSet<Auto> Auto { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Contrat> Contrat { get; set; }
        public virtual DbSet<Entreprise> Entreprise { get; set; }
        public virtual DbSet<Expert> Expert { get; set; }
        public virtual DbSet<habitation1> habitation1 { get; set; }
        public virtual DbSet<Moto> Moto { get; set; }
        public virtual DbSet<Produit> Produit { get; set; }
        public virtual DbSet<Risque_diver> Risque_diver { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
