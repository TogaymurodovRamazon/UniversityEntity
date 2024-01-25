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
    public class StudentsRepository : IStudentsRepository
    {
        private readonly AppDBContext _appDBContext;
        public StudentsRepository()
        {
            _appDBContext = new AppDBContext();
        }
        public async Task Insert(Students student)
        {
            _appDBContext.student.Add(student);
            _appDBContext.SaveChanges();
        }

        public async Task Delete(int id)
        {
            var student= _appDBContext.student.FirstOrDefault(x => x.Id==id);
            _appDBContext.student.Remove(student);
            _appDBContext.SaveChangesAsync();
        }

        public List<Students> GetAll()
         =>_appDBContext.student.ToList();

        public async Task Update(int id, Students student)
        {
            var student1 = _appDBContext.student.FirstOrDefault(x => x.Id == id);
            student.Id=id;
            _appDBContext.student.Attach(student1).CurrentValues.SetValues(student);
            _appDBContext.SaveChanges();
        }
    }
}
