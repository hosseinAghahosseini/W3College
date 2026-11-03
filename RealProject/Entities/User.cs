using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealProject.Entities
{
    public class User : Base
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        public string PhoneNumber { get; set; }


        [StringLength(128, MinimumLength = 8)]
        public string Password { get; set; }

        [NotMapped]
        public string RePassword { get; set; }
        public string ImageUrl { get; set; } = "/images/omreh.svg";
    }
}
