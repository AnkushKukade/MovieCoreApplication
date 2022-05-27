using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.Entity;
using MovieApp.Data.Repositories;

namespace MovieApp.Data.DataConnection
{
    public class MovieDbContext:DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options):base(options)
        {

        }
        public DbSet<MovieModel> movieModel { get; set; }
      
        public DbSet<UserModel> userModel { get; set; }
    }
}
