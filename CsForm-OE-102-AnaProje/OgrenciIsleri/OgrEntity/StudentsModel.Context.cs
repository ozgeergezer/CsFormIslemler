﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CsForm_OE_102_AnaProje.OgrenciIsleri.OgrEntity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StudentsEntities : DbContext
    {
        public StudentsEntities()
            : base("name=StudentsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TblSehirler> TblSehirler { get; set; }
        public virtual DbSet<TblDepartments> TblDepartments { get; set; }
        public virtual DbSet<TblOgrBilgiler> TblOgrBilgiler { get; set; }
    }
}
