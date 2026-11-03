using System.ComponentModel.DataAnnotations;

namespace RealProject.Entities
{
    public class Tutorial : Base
    {
        public uint StartTime { get; set; }
        public uint EndTime { get; set; }
        public string? HTML { get; set; }

        //foreign keys
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
    }
}
