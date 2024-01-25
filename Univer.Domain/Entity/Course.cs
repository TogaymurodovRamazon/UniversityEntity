using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Univer.Domain.Common;

namespace Univer.Domain.Entity
{
    public class Course :Auditable
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public int Price { get; set; }
    }
}
