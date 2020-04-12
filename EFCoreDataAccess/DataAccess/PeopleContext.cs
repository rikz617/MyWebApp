using EFCoreDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreDataAccess.DataAccess
{
    public class PeopleContext : DbContext
    {
        public PeopleContext(DbContextOptions options) : base(options) { }
        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Email> EmailsAddress { get; set; }
        public DbSet<Value> Values { get; set; }
       
        protected override void OnModelCreating(ModelBuilder builder) 
        {
            builder.Entity<Value>().
                HasData(
                new Value { Id = 1, Name = "001" },
                new Value { Id = 2, Name = "002" },
                new Value { Id = 3, Name = "002" }
                );
            }

        }
 }

