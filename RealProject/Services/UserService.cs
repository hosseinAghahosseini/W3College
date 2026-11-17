using RealProject.Entities;

namespace RealProject.Services
{
    public class UserService : BaseService<Instructor>
    {
        public UserService(AppDbContext context) : base(context) { }
    }
}
