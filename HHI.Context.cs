﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HHI_InspectionSoftware
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HHIEntities4 : DbContext
    {
        public HHIEntities4()
            : base("name=HHIEntities4")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<CheckItem> CheckItem { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<HomeSystem> HomeSystem { get; set; }
        public virtual DbSet<Inspection> Inspection { get; set; }
        public virtual DbSet<InspectionStatus> InspectionStatus { get; set; }
        public virtual DbSet<Inspector> Inspector { get; set; }
        public virtual DbSet<Limitation> Limitation { get; set; }
        public virtual DbSet<Realtor> Realtor { get; set; }
        public virtual DbSet<Template> Template { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Images> Images { get; set; }
    }
}
