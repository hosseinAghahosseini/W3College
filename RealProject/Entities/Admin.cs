using System.ComponentModel.DataAnnotations;

namespace RealProject.Entities
{
    public class Admin : User
    {
        public string ImageUrl { get; set; } = "/images/admin.svg";
    }
}
