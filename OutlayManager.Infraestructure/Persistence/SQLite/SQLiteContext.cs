﻿using Microsoft.EntityFrameworkCore;
using OutlayManagerAPI.Infraestructure.Persistence;
using OutlayManagerCore.Infraestructure.Persistence.Model;
using System;

namespace OutlayManagerCore.Infraestructure.Persistence.SQLite
{
    internal class SQLiteContext : DbContext, IOutlayDBContext
    {
        protected readonly string _connectionString;

        public DbSet<TransactionOutlay> TransactionOutlay { get; set; }

        public DbSet<MCodeTransaction> MCodeTransaction { get; set; }

        public DbSet<MTypeTransaction> MTypeTransaction { get; set; }

        public DbContext Context => this;

        private SQLiteContext() { }

        public SQLiteContext(string connectionString):base()
        {
            _connectionString = connectionString 
                ?? throw new ArgumentException("Connection string is required");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_connectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
