using AutoMapper;
using MiniProject.Common.DTOs;
using MiniProject.Repositories.Entities;
using MiniProject.Repositories.Interfaces;
using MiniProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Services.Services
{
    public class UserDetailsService : IUserDetailsService
    {
        private readonly IUserDetailsRepository _userDetails;
        private readonly IMapper _mapper;

        public UserDetailsService(IUserDetailsRepository userDetails, IMapper mapper)
        {
            _userDetails = userDetails;
            _mapper = mapper;
        }

        public async Task<UserDetailsDTO> AddAsync(string firstName, string lastName, string idNumber, DateTime birthDate, string gender, string hmo, List<ChildDTO> children)
        {

            return _mapper.Map<UserDetailsDTO>(await _userDetails.AddAsync(firstName, lastName, idNumber, birthDate, gender, hmo, _mapper.Map<List<Child>>(children)));
        }

        public async Task<List<UserDetailsDTO>> GetAllAsync()
        {
            return _mapper.Map<List<UserDetailsDTO>>(await _userDetails.GetAllAsync());
        }

        public async Task<UserDetailsDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<UserDetailsDTO>(await _userDetails.GetByIdAsync(id));
        }
    }
}
