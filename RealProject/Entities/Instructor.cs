using System.ComponentModel.DataAnnotations;

namespace RealProject.Entities
{
    public class Instructor : Base
    {
        public string Name { get; set; } = "استاد عمره";
        public string? Email { get; set; }
        public string? About { get; set; }
        public string ImageUrl { get; set; } = "/images/ostad_omreh.svg";

        public List<Course> Courses { get; set; }
    }
}
