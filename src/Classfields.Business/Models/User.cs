using System.Collections.Generic;

namespace Classfields.Business.Models
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public bool Verified { get; set; }
        public Post Post { get; set; }
    }
}