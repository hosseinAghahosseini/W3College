using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace RealProject.Entities
{
    public enum VideoQuality
    {
        [Display(Name = "480p")]
        Low,
        [Display(Name = "720p")]
        Medium,
        [Display(Name = "1080p")]
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

        public static List<Tuple<string, VideoQuality>> GetQualityList()
        {
            var res = RealProject.Entities.VideoQuality
                .GetValues(typeof(VideoQuality))
                .Cast<VideoQuality>()
                .ToList();

            List<Tuple<string, VideoQuality>> ListQ = new List<Tuple<string, VideoQuality>>();

            foreach (var quality in res)
            {
                var displayName = quality.GetType()
                    .GetField(quality.ToString())
                    .GetCustomAttribute<DisplayAttribute>()
                    ?.Name ?? quality.ToString();

                ListQ.Add(Tuple.Create(displayName, quality));
            }

            return ListQ;
        }
    }
}
