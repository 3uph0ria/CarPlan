﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace vcids.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CarPlanEntities : DbContext
    {
        public CarPlanEntities()
            : base("name=CarPlanEntities")
        {
        }


        public static CarPlanEntities context;
        public static CarPlanEntities GetContext()
        {
            if (context == null)
                context = new CarPlanEntities();
            return context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Adverts> Adverts { get; set; }
        public virtual DbSet<Cars> Cars { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<Permissions> Permissions { get; set; }
        public virtual DbSet<Sales> Sales { get; set; }
        public virtual DbSet<TypeEvents> TypeEvents { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
