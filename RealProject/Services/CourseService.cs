using Microsoft.EntityFrameworkCore;
using RealProject.Entities;

namespace RealProject.Services
{
    public class CourseService
    {
        private readonly AppDbContext _context;
        public CourseService(AppDbContext context)
        {
            _context = context;
        }

        public int Create(Course course)
        {
            _context.Courses.Add(course);
            var res = _context.SaveChanges();
            return res;
        }

        public Course Read(int Id)
        {
            //select * from courses where Id = @Id
            var res = _context.Courses.FirstOrDefault(c => c.Id == Id);
            return res;
        }

        public List<Course> ReadAll()
        {
            //select * from courses
            var res = _context.Courses.ToList();
            return res;
        }

        public int Update(Course course)
        {
            _context.Courses.Update(course);
            var res = _context.SaveChanges();
            return res;
        }

        public int Delete(int Id)
        {
            var course = _context.Courses.FirstOrDefault(c => c.Id == Id);
            if(course == null) return 0;
            _context.Courses.Remove(course);
            var res = _context.SaveChanges();
            return res;
        }
    }
}
