﻿using MicroRabbit.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Data.Context
{
    public class BankingDbContext: DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        public BankingDbContext(DbContextOptions<BankingDbContext> options): base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(
                    "Data Source=TOM-HPENVY-16;Initial Catalog=BankingDB;MultipleActiveResultSets=true;User Id=sa;Password=t0mmyb0y;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
                );
            }
        }


    }
}
