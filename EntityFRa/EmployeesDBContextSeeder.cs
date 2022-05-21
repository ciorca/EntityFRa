using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFRa
{
    public class EmployeesDBContextSeeder : DropCreateDatabaseIfModelChanges<EmployeeDBContext>
    {
        protected override void Seed(EmployeeDBContext context)
        {
            Department department1 = new Department()
            {
                Name = "IT",
                Location = "New York",
                Employees = new List<Employee>()
                {
                    new Employee()
                    {
                        FirstName ="Mark",
                         LastName = "Hastings",
                         Gender ="Male",
                         Salary = 60000,
                         JobTitle = "Developer"
                     },
                    new Employee()
                    {
                        FirstName ="Steve",
                         LastName = "POUND",
                         Gender ="Male",
                         Salary = 45000,
                         JobTitle = "MANAGER"
                     }
                    }
            };
            Department department2 = new Department()
            {
                Name = "HR",
                Location = "London",
                Employees = new List<Employee>()
                {
                    new Employee()
                    {
                        FirstName = "PHILIP",
                        LastName = "Hastings",
                        Gender = "Male",
                        Salary = 45000,
                        JobTitle = "RECRUITER",
                    },
                new Employee()
                {
                    FirstName = "BEN",
                    LastName = "HOSKINS",
                    Gender = "Male",
                    Salary = 70000,
                    JobTitle = "Manager",
                }
                }
            };


                Department department3 = new Department()
                {
                    Name = "Payroll",
                    Location = "Sidney",
                    Employees = new List<Employee>()
                    { 

                    new Employee()
                    {
                        FirstName = "MARY",
                        LastName = "LAMBETH",
                        Gender = "FEMALE",
                        Salary = 30000,
                        JobTitle = "Payroll Agent",
                    },
                    new Employee()
                    {
                        FirstName = "Valery",
                        LastName = "Jackson",
                        Gender = "FEMALE",
                        Salary = 75000,
                        JobTitle = "Payroll Admin",
                    }
                }
            };
            context.Departments.Add(department1);
            context.Departments.Add(department2);
            context.Departments.Add(department3);


            base.Seed(context);
        }
    }
}