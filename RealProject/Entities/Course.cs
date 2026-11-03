using System.ComponentModel.DataAnnotations;

namespace RealProject.Entities
{
    public class Course : Base
    {
        public string Name { get; set; }
        public long Price { get; set; }
        public int VoteScore { get; set; }
        public string? Description { get; set; }
        //public string? Slug { get; set; }
        public string? ThumbnailUrl { get; set; }

        //foreign keys
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }

        public List<Topic> Topics { get; set; }
    }
}
