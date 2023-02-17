using Microsoft.EntityFrameworkCore;
using MiniProject.Repositories.Entities;
using MiniProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Repositories.Repositories
{
    public class UserDetailsRepository : IUserDetailsRepository
    {
        private readonly IContext _context;

        public UserDetailsRepository(IContext context)
        {
            _context = context;
        }

        public async Task<UserDetails> AddAsync(UserDetails details)
        {
            var t=_context.UserDetails.Add(details);
            await _context.SaveChangesAsync();
            return t.Entity;
        }

        public async Task<List<UserDetails>> GetAllAsync()
        {
            return await _context.UserDetails.Include(user=>user.Children).ToListAsync();
        }

        public async Task<UserDetails> GetByIdAsync(int id)
        {
            return await _context.UserDetails.Include(user=>user.Children).FirstOrDefaultAsync(c=> c.Id == id);
        }
    }
}
