using System.ComponentModel.DataAnnotations;

namespace RealProject.Entities
{
    public class Quiz : Base
    {
        public string Title { get; set; }
        public string Question { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string? Option3 { get; set; }
        public string? Option4 { get; set; }
        public short Answer { get; set; }

        //foreign keys
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
    }
}
