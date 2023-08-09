using AspNetCoreMVCPj.Models;
using AspNetCoreMVCPj.Models;

namespace AspNetCoreMVCPj.Repositories
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Mary", Department = Dept.HR, Email = "mary@gmail.com" },
                new Employee() { Id = 2, Name = "John", Department = Dept.IT, Email = "john@gmail.com" },
                new Employee() { Id = 3, Name = "Sam", Department = Dept.IT, Email = "sam@gmail.com" },
            };
        }

        public Employee AddEmployee(Employee employee)
        {
            employee.Id = _employeeList.Max(emp => emp.Id) + 1;
            _employeeList.Add(employee);
            return employee;
        }

        public Employee DeleteEmployee(int id)
        {
            Employee? employee = _employeeList.FirstOrDefault(e => e.Id == id);

            if(employee != null)
            {
                _employeeList.Remove(employee);
            }

            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }

        public Employee UpdateEmployee(Employee employee)
        {
           Employee? changesEmployee = _employeeList.FirstOrDefault(emp=>emp.Id == employee.Id);

            if(changesEmployee != null)
            {
                changesEmployee.Name = employee.Name;
                changesEmployee.Department = employee.Department;
                changesEmployee.Email = employee.Email;
            }

            return changesEmployee;
        }
    }
}
