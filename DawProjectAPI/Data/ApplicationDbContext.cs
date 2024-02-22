﻿using DawProjectAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DawProjectAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}