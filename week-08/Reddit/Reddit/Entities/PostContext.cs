﻿using Microsoft.EntityFrameworkCore;
using Reddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Entities
{
    public class PostContext : DbContext
    {
        public PostContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(x => x.Posts)
                .WithOne(x => x.User)
                .HasPrincipalKey(x => x.Id);
        }
    }
}
