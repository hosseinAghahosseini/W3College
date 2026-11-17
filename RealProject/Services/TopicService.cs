using Microsoft.EntityFrameworkCore;
using RealProject.Entities;

namespace RealProject.Services
{
    public class TopicService : BaseService<Topic>
    {
        public TopicService(AppDbContext context) : base(context) { }

        public List<Topic> GetTopicsByCourseId(int CourseId, int PageNum = 1, int PageSize = 3)
        {
            //select top 1 * from Topics where courseId = @CourseId
            //var res = _context.Topics
            //    .First( c => c.CourseId == CourseId);

            //select * from topics join courses on topics.courseId = courses.Id where courseId = @courseId
            var res = _context.Topics
                .Where(c => c.CourseId == CourseId)
                .Include( c => c.Course )
                .Skip((PageNum - 1) * PageSize)
                .Take(PageSize)
                .OrderBy(c => c.Order)
                .ToList();

            //select * from Topics where title like '%go%'
            //var res2 = _context.Topics
            //    .Where(c => c.Title.Contains("go"))
            //    .ToList();

            //var res3 = _context.Topics
            //    .Where(c => c.CreationDate > DateTime.Now.AddMonths(-1) &&
            //        c.CreationDate < DateTime.Now.AddDays(-1))
            //    .ToList();

            return res;
        }

        public int GetCountTopicByCourseId(int CourseId)
        {
            return _context.Topics
                .Count(c => c.CourseId == CourseId);
        }
    }
}
