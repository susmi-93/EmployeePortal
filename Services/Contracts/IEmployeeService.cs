using System.Collections.Generic;
using Repository.Entity;
using Services.Models;

namespace Services.Contracts
{
    public interface IEmployeeService
    {
        void AddEmployee(Employee e);
        IList<EmployeeModel> ListEmployees();
        void RemoveEmployee(Employee e);
    }
}