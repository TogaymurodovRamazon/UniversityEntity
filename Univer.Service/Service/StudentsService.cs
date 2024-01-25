using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univer.Data.IRepository;
using Univer.Data.Repository;
using Univer.Domain.Entity;
using Univer.Service.IService;

namespace Univer.Service.Service
{
    public class StudentsService : IStudentsService
    {
        private readonly IStudentsRepository repository;
        public StudentsService()
        {
            repository=new StudentsRepository();
        }

        public Task Delete(int id)
        =>repository.Delete(id);

        public List<Students> GetAll()
       =>repository.GetAll();

        public Task Insert(Students student)
        =>repository.Insert(student);

        public Task Update(int id, Students student)
        =>repository.Update(id,student);
    }
}
