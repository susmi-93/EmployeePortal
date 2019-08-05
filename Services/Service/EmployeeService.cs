using AutoMapper;
using Repository.Contracts;
using Repository.Entity;
using Services.Bootstrap;
using Services.Contracts;
using Services.Models;
using System.Collections.Generic;

namespace Services.Service
{
    public class EmployeeService : IEmployeeService
    {
        IEmployeeRepository Repo;
        public EmployeeService(IEmployeeRepository repo)
        {
            Repo = repo;
        }
        public IList<EmployeeModel> ListEmployees()
        {
            var result = Repo.ListEmployees();
            return Automapper.Mapper.Map<IList<EmployeeModel>>(result);
        }
        public void AddEmployee(Employee e)
        {
            Repo.AddEmployee(e);
        }
        public void RemoveEmployee(Employee e)
        {
            Repo.RemoveEmployee(e);
        }

    }
}
