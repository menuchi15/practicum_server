using Microsoft.EntityFrameworkCore;
using MiniProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Repositories.Interfaces
{
    public interface IContext
    {
        public DbSet<UserDetails> UserDetails { get; set; }

        public DbSet<Child> Children { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
