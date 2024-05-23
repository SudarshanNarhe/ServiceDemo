using ServiceDemo.Models;

namespace ServiceDemo.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetEmployees();

        Employee GetEmployeeById(int employeeId);

        int AddEmployee(Employee employee);

        int UpdateEmployee(Employee employee);

        int DeleteEmployee(int employeeId);
    }
}
