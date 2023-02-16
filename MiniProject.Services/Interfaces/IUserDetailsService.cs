using MiniProject.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Services.Interfaces
{
    public interface IUserDetailsService
    {
        Task<List<UserDetailsDTO>> GetAllAsync();

        Task<UserDetailsDTO> GetByIdAsync(int id);

        Task<UserDetailsDTO> AddAsync(UserDetailsDTO details);
    }
}
