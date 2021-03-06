﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using PandaBookStore.Data.Entities;
using JetBrains.Annotations;
using Microsoft.Extensions.Configuration;

namespace PandaBookStore.Data
{
    public class StoreContext : DbContext//, IStoreContext
    {
        private string connectionString = string.Empty;

        private IConfigurationRoot configurationRoot;

        #region DbSets

        public DbSet<Book> Books { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderDetails { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Comment> Recommendations { get; set; }

        public DbSet<Picture> Pictures { get; set; }

        public DbSet<Message> Contacts { get; set; }

        #endregion

        public StoreContext(DbContextOptions opt) : base(opt) //IConfigurationRoot configurationRoot)
        {
            //this.connectionString = connStr;
            //this.configurationRoot = configurationRoot;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlServer(this.connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.AddConfiguration(new BlogMap());
        }

        public bool ProxyCreationEnabled { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool AutoDetectChangesEnabled { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Detach(object entity)
        {
            throw new NotImplementedException();
        }

        public int ExecuteSqlCommand(string sql, bool doNotEnsureTransaction = false, int? timeout = null, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> ExecuteStoredProcedureList<TEntity>(string commandText, params object[] parameters) where TEntity : BaseEntity, new()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TElement> SqlQuery<TElement>(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
