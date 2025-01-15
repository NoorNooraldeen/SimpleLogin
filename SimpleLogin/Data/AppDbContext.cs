﻿using Microsoft.EntityFrameworkCore;
using SimpleLogin.Models;

namespace SimpleLogin.Data
{
    public class AppDbContext : DbContext
    {


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
             public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
    }
    

