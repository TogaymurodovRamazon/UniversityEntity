using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univer.Domain.Common;

namespace Univer.Domain.Entity
{
    public class Students : Auditable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Course { get; set; }
        public string PhoneNumber { get; set; }
        public int Payment { get; set; }
    }
}
