using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univer.Domain.Entity;

namespace Univer.Data.IRepository
{
    public interface ICourseRepository
    {
        Task Insert(Course course);
        List<Course> GetAll();
        Task Delete(int id);
        Task Update(int id, Course course);
    }
}
