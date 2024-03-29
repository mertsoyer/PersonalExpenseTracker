﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Personal_Expense_Tracker.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Personal_Expense_Tracker.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
            : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SP14MERTS;Database=ExpenseTracking;Trusted_Connection=True;MultipleActiveResultSets=true");
        }


        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }
        
    }
}
