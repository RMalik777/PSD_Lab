﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KpopZtation
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class localDBEntities1 : DbContext
    {
        public localDBEntities1()
            : base("name=localDBEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<msAlbum> msAlbums { get; set; }
        public virtual DbSet<msArtist> msArtists { get; set; }
        public virtual DbSet<msCart> msCarts { get; set; }
        public virtual DbSet<msCustomer> msCustomers { get; set; }
        public virtual DbSet<msTransactionDetail> msTransactionDetails { get; set; }
        public virtual DbSet<msTransactionHeader> msTransactionHeaders { get; set; }
    }
}