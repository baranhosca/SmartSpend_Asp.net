﻿using Microsoft.EntityFrameworkCore;

namespace SmartSpend.Models
{
    public class SmartSpendDbContext : DbContext
    {
       public DbSet<Expense> Expenses { get; set; }

        public SmartSpendDbContext(DbContextOptions<SmartSpendDbContext> options) 
            : base(options)
        {
            
        }
    }
}
