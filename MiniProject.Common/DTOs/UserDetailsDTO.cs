using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Common.DTOs
{
    public class UserDetailsDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string HMO { get; set; }
        public List<ChildDTO> Children{ get; set; }
    }
}
