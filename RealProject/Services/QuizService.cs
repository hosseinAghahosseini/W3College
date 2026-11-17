using RealProject.Entities;

namespace RealProject.Services
{
    public class QuizService : BaseService<Topic>
    {
        public QuizService(AppDbContext context) : base(context) { }
    }
}
