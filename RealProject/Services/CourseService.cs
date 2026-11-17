using Microsoft.EntityFrameworkCore;
using RealProject.Entities;

namespace RealProject.Services
{
    public class CourseService : BaseService<Course>
    {
        public CourseService(AppDbContext context) : base(context) { }

        //public Course? GetAllVideosOfACousre(int courseId)
        public List<Video> GetAllVideosOfACousre(int courseId)
        {
            return _context.Videos
                .Include(c => c.Topic)
                .ThenInclude(c => c.Course)
                .Where(c => c.Topic.CourseId == courseId)
                .ToList();

            //return _context.Courses
            //    .Include(c => c.Topics)
            //    .ThenInclude(c => c.Videos)
            //    .FirstOrDefault(c => courseId == c.Id);
        }
    }
}
