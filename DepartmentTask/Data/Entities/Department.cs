using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentTask.Data.Entities
{
   public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Company Company { get; set; }
        public int CompanyId { get; set; }
    }
}
