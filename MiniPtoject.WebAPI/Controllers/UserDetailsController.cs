using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniProject.Common.DTOs;
using MiniProject.Services.Interfaces;
using MiniProject.WebAPI.Models;

namespace MiniProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDetailsController : ControllerBase
    {
        private readonly IUserDetailsService _userDetailsService;

        public UserDetailsController(IUserDetailsService userDetailsService)
        {
            _userDetailsService = userDetailsService;
        }

        [HttpGet]
        public async Task<List<UserDetailsDTO>> GetAllAsync()
        {
            return await _userDetailsService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<UserDetailsDTO> GetByIdAsync(int id)
        {
            return await _userDetailsService.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<UserDetailsDTO> AddAsync([FromBody] DetailsModel d)
        {
            return await _userDetailsService.AddAsync(d.FirstName, d.LastName, d.IdNumber, d.BirthDate, d.Gender, d.HMO,d.Children);
        }
    }
}
