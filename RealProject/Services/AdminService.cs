using RealProject.Entities;

namespace RealProject.Services
{
    public class AdminService : BaseService<Instructor>
    {
        public AdminService(AppDbContext context) : base(context) { }
    }
}
