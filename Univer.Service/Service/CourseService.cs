using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univer.Data.IRepository;
using Univer.Data.Repository;
using Univer.Domain.Entity;

namespace Univer.Service.Service
{
    public class CourseService : ICourseRepository
    {
        private readonly ICourseRepository repository;
        public CourseService()
        {
            repository=new CourseRepository();
        }
        public Task Delete(int id)
         =>repository.Delete(id);

        public List<Course> GetAll()
         =>repository.GetAll();

        public Task Insert(Course course)
         =>repository.Insert(course);

        public Task Update(int id, Course course)
          =>repository.Update(id, course);
    }
}
