using RealProject.Entities;

namespace RealProject.Services
{
    public class TutorialService : BaseService<Topic>
    {
        public TutorialService(AppDbContext context) : base(context) { }
    }
}
