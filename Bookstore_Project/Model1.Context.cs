﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bookstore_Project
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class My_ProgectEntities4 : DbContext
    {
        public My_ProgectEntities4()
            : base("name=My_ProgectEntities4")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ClientSet> ClientSet { get; set; }
        public virtual DbSet<ProductSet> ProductSet { get; set; }
        public virtual DbSet<ProductTraking> ProductTraking { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<WorkerSet> WorkerSet { get; set; }
    }
}
