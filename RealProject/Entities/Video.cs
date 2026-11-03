using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealProject.Entities
{
    public enum VideoQuality
    {
        Low,
        Medium,
        High
    }
    public class Video : Base
    {
        public string? ThumbnailUrl { get; set; }
        public string? VideoUrl { get; set; }
        public VideoQuality? VideoQuality { get; set; }
        public int Length { get; set; }

        //foreign keys
        [ForeignKey("TopicId")]
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
    }
}
