using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univer.Data.DBContexts;
using Univer.Data.IRepository;
using Univer.Domain.Entity;

namespace Univer.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly AppDBContext dbContext;
        public CourseRepository()
        {
            dbContext = new AppDBContext();
        }
        public async Task Delete(int id)
        {
          var course1=dbContext.course.FirstOrDefault(c => c.Id == id);
            dbContext.course.Remove(course1);
            dbContext.SaveChangesAsync();
        }

        public List<Course> GetAll()
         =>dbContext.course.ToList();

        public async Task Insert(Course course)
        {
          dbContext.course.Add(course);
            dbContext.SaveChanges();
        }

        public async Task Update(int id, Course course)
        {
            var course1 = dbContext.course.FirstOrDefault(c => c.Id == id);
            course.Id = id;
            dbContext.course.Attach(course1).CurrentValues.SetValues(course);
            dbContext.SaveChanges();
        }
    }
}
