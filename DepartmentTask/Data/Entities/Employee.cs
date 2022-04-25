using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentTask.Data.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public int Salary { get; set; }
        public Company Company { get; set; }

        public int CompanyId { get; set; }
    }
}
