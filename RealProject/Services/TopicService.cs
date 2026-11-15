using RealProject.Entities;

namespace RealProject.Services
{
    public class TopicService : BaseService<Topic>
    {
        private readonly AppDbContext _context;
        public TopicService(AppDbContext context) : base(context) { }
    }
}
