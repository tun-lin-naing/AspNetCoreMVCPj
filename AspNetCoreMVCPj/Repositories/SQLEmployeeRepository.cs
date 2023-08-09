﻿using AspNetCoreMVCPj.Models;

namespace AspNetCoreMVCPj.Repositories
{
    public class SQLEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext context;

        public SQLEmployeeRepository(AppDbContext context)
        {
            this.context = context;
        }


        public Employee AddEmployee(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return employee;
        }

        public Employee DeleteEmployee(int id)
        {
            Employee employee = context.Employees.Find(id);

            if (employee != null)
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
            }

            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return context.Employees;
        }

        public Employee GetEmployee(int id)
        {
            return context.Employees.Find(id);
        }

        public Employee UpdateEmployee(Employee employee)
        {
            var employeeChanges = context.Employees.Attach(employee);
            employeeChanges.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();

            return employee;
        }
    }
}
