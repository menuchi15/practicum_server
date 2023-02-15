using MiniProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Repositories.Interfaces
{
    public interface IUserDetailsRepository
    {
        Task<List<UserDetails>> GetAllAsync();

        Task<UserDetails> GetByIdAsync(int id);

        Task<UserDetails> AddAsync(string firstName,string lastName,string idNumber,DateTime birthDate, string gender, string hmo,List<Child> children);
    }
}
