using RealProject.Entities;

namespace RealProject.Services
{
    public class UserService
    {
        private readonly AppDbContext _context;
        public UserService(AppDbContext context)
        {
            _context = context;
        }


        public int Register(User user)
        {
            _context.Users.Add(user);
            var res = _context.SaveChanges();
            return res;
        }
    }
}
