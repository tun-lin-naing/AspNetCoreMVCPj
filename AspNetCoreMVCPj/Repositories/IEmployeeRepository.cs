using AspNetCoreMVCPj.Models.Employee;

namespace AspNetCoreMVCPj.Repositories
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);

        IEnumerable<Employee> GetAllEmployee();
    }
}
