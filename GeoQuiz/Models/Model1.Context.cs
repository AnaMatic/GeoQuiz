﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GeoQuizEntities : DbContext
    {
        public GeoQuizEntities()
            : base("name=GeoQuizEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Drzava> Drzava { get; set; }
        public virtual DbSet<HighScore> HighScore { get; set; }
        public virtual DbSet<Kontinent> Kontinent { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
