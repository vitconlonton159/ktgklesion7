﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ktbst2210900075.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class buisontung2210900075Entities1 : DbContext
    {
        public buisontung2210900075Entities1()
            : base("name=buisontung2210900075Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BstKhoa> BstKhoas { get; set; }
        public virtual DbSet<BstSinhVien> BstSinhViens { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}