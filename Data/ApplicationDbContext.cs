﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Entity_Framework_Core_String_Filter_Tips.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        public DbSet<Contact> Contacts {get;set;}  

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.Entity<Contact>()
                .HasData(
                    new Contact 
                    {
                        Id = 1,
                        FirstName = "Bob",
                        LastName = "Smith",
                        Address = "123 Main Street",
                        City = "Nashville",
                        State = "TN",
                        Zip = "35970"
                    },
                    new Contact
                    {
                        Id = 2,
                        FirstName = "Sam",
                        LastName = "Smith",
                        Address = "1 Sun Lane",
                        City = "Knoxville",
                        State = "TN",
                        Zip = "48909"
                    },
                    new Contact
                    {
                        Id = 3,
                        FirstName = "Clark",
                        LastName = "Swift",
                        Address = "750 10th Street",
                        City = "Chattanooga",
                        State = "TN",
                        Zip = "91590"
                    }
                );
            base.OnModelCreating(builder);
        }
    }
}
