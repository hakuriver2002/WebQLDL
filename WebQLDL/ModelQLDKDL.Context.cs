//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebQLDL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLDKDULICHEntities1 : DbContext
    {
        public QLDKDULICHEntities1()
            : base("name=QLDKDULICHEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tChuyenDuLich> tChuyenDuLich { get; set; }
        public virtual DbSet<tDangKy> tDangKy { get; set; }
        public virtual DbSet<tDiaDiemThamQuan> tDiaDiemThamQuan { get; set; }
        public virtual DbSet<tKhach> tKhach { get; set; }
        public virtual DbSet<tTuyen> tTuyen { get; set; }
    }
}
