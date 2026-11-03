using System.ComponentModel.DataAnnotations;

namespace RealProject.Entities
{
    public class Topic : Base
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public int Order { get; set; }

        //foreign keys
        public int CourseId { get; set; }
        public Course Course { get; set; }

        public List<Video> Videos { get; set; }
        public List<Tutorial> Tutorials { get; set; }
        public List<Quiz> Quizes { get; set; }
    }
}
