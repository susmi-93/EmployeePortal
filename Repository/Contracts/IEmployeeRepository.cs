using Repository.Entity;
using System.Collections.Generic;

namespace Repository.Contracts
{
    public interface IEmployeeRepository
    {
        IList<Employee> ListEmployees();
        void AddEmployee(Employee e);
        void RemoveEmployee(Employee e);
    }
}
