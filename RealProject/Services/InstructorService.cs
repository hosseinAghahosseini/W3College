using RealProject.Entities;

namespace RealProject.Services
{
    public class InstructorService : BaseService<Instructor>
    {
        private readonly AppDbContext _context;
        public InstructorService(AppDbContext context) : base(context) { }
    }
}
