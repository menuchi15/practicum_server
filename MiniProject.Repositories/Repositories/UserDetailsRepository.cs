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

        public async Task<UserDetails> AddAsync(string firstName, string lastName, string idNumber, DateTime birthDate, string gender, string hmo, List<Child> children)
        {
            var t=_context.UserDetails.Add(new UserDetails { FirstName = firstName, LastName = lastName, IdNumber = idNumber, BirthDate = birthDate, Gender = gender, HMO = hmo, Children = children });
            await _context.SaveChangesAsync();
            return t.Entity;
        }
        public async Task<List<UserDetails>> GetAllAsync()
        {
            return await _context.UserDetails.ToListAsync();
        }

        public async Task<UserDetails> GetByIdAsync(int id)
        {
            return await _context.UserDetails.FindAsync(id);
        }
    }
}
