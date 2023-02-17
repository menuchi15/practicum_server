using MiniProject.Common.DTOs;
using MiniProject.Repositories.Entities;

namespace MiniProject.WebAPI.Models
{
    public class DetailsModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string IdNumber { get; set; }

        public DateTime BirthDate { get; set; }

        public string Gender { get; set; }

        public string HMO { get; set; }

        public List<ChildDTO> Children { get; set; }
        
    }
}
