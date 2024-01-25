using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univer.Domain.Entity;

namespace Univer.Service.IService
{
    public interface IStudentsService
    {
        Task Insert(Students student);
        List<Students> GetAll();
        Task Delete(int id);
        Task Update(int id, Students student);
    }
}
