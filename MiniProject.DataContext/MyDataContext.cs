using Microsoft.EntityFrameworkCore;
using MiniProject.Repositories.Entities;
using MiniProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.DataContext
{
    public class MyDataContext :DbContext,IContext
    { 
        public DbSet<UserDetails> UserDetails { get; set; }
        
        public DbSet<Child> Children{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MiniProjectDB;Trusted_Connection=True;");
    }
}
