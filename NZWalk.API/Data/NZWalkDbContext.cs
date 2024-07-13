﻿using Microsoft.EntityFrameworkCore;
using NZWalk.API.Models.Domain;

namespace NZWalk.API.Data
{
    public class NZWalkDbContext : DbContext
    {
        public NZWalkDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
    }
}
