﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RiceMill5911.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RiceMill5911Entities : DbContext
    {
        public RiceMill5911Entities()
            : base("name=RiceMill5911Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BookingDescription> BookingDescription { get; set; }
        public virtual DbSet<BookingForm> BookingForm { get; set; }
        public virtual DbSet<BuyDescription> BuyDescription { get; set; }
        public virtual DbSet<BuyForm> BuyForm { get; set; }
        public virtual DbSet<Condition> Condition { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Dealer> Dealer { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Rice> Rice { get; set; }
        public virtual DbSet<StatusBooking> StatusBooking { get; set; }
        public virtual DbSet<StatusRice> StatusRice { get; set; }
        public virtual DbSet<TypeRice> TypeRice { get; set; }
        public virtual DbSet<UserLogin> UserLogin { get; set; }
    }
}
