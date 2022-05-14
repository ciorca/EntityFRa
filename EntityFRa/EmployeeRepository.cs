using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFRa
{
    public class EmployeeRepository
    {

        public List<Department>GetDepartments()
        {

            EmployeeDBContext employeeDBContext = new EmployeeDBContext();
            return employeeDBContext.Departments.ToList();
        }
    }
}