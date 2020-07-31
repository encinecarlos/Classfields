using System;

namespace Classfields.Business.Models
{
    public class Post : Entity
    {
        public Post(User user)
        {
            User = user;
        }

        //public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Email { get; set; }
        public string Ethnicity { get; set; }
        public string Eyes { get; set; }
        public string SocialNetworks { get; set; }
        public string Gender { get; set; }
        public string Height { get; set; }
        public string Hips { get; set; }
        public string Hair_Color { get; set; }
        public int Incall { get; set; }
        public int Outcall { get; set; }
        public string Affiliation { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int Status { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Waist { get; set; }
        public string Weight { get; set; }
        public string Bust { get; set; }
        public string Cup { get; set; }
        public string AvailableTo { get; set; }
        public DateTime BumpedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}