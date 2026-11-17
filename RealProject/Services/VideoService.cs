using RealProject.Entities;

namespace RealProject.Services
{
    public class VideoService : BaseService<Video>
    {
        public VideoService(AppDbContext context) : base(context) { }
    }
}
