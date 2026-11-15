using RealProject.Entities;

namespace RealProject.Services
{
    public class VideoService : BaseService<Video>
    {
        private readonly AppDbContext _context;
        public VideoService(AppDbContext context) : base(context) { }
    }
}
