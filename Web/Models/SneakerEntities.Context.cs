﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SneakerEntities : DbContext
    {
        public SneakerEntities()
            : base("name=SneakerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BINHLUAN> BINHLUANs { get; set; }
        public DbSet<CATALOGY> CATALOGies { get; set; }
        public DbSet<MANAGER> MANAGERs { get; set; }
        public DbSet<NHASX> NHASXes { get; set; }
        public DbSet<QUANGCAO> QUANGCAOs { get; set; }
        public DbSet<SANPHAM> SANPHAMs { get; set; }
        public DbSet<SEO> SEOs { get; set; }
        public DbSet<SLIDEPHOTO> SLIDEPHOTOes { get; set; }
        public DbSet<USER> USERS { get; set; }
        public DbSet<GIOITHIEU> GIOITHIEUx { get; set; }
        public DbSet<LIEN_HE> LIEN_HE { get; set; }
        public DbSet<PHANHOI_GOPY> PHANHOI_GOPY { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<TINTUC> TINTUCs { get; set; }
        public DbSet<CT_DATHANG> CT_DATHANG { get; set; }
        public DbSet<DATHANG> DATHANGs { get; set; }
        public DbSet<SIZE> SIZEs { get; set; }
    }
}