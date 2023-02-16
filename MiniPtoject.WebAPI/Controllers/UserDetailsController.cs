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
        public async Task<ActionResult<UserDetailsDTO>> AddAsync([FromBody] DetailsModel d)
        {
            List<ChildDTO> cl = new List<ChildDTO>();
            foreach(ChildModel child in d.Children)
            {
                cl.Add(new ChildDTO { Name= child.Name ,IdNumber=child.IdNumber,BirthDate=child.BirthDate});
            }
            return await _userDetailsService.AddAsync(new UserDetailsDTO { FirstName = d.FirstName, LastName = d.LastName, IdNumber = d.IdNumber, BirthDate = d.BirthDate, Gender = d.Gender, HMO = d.HMO, Children = cl });
        }
    }
}
