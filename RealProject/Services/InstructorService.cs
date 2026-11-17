using RealProject.Entities;

namespace RealProject.Services
{
    public class InstructorService : BaseService<Instructor>
    {
        public InstructorService(AppDbContext context) : base(context) { }
    }
}
