using System.Collections.Generic;
using Repository.Entity;
using Repository.Contracts;
namespace Repository.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        List<Employee> Employees = new List<Employee>();
        public EmployeeRepository ()
	    {
            Employee e1 = new Employee(1,"Thomas Hardy","thomashardy@mail.com","89 Chiaroscuro Rd, Portland, USA","(171) 555-2222");
            Employees.Add(e1);
            Employee e2 = new Employee(2,"Dominique Perrier","dominiqueperrier@mail.com","Obere Str. 57, Berlin, Germany","(313) 555-5735");
            Employees.Add(e2);
            Employee e3 = new Employee(3,"Maria Anders","mariaanders@mail.com","25, rue Lauriston, Paris, France","(503) 555-9931");
            Employees.Add(e3);
            Employee e4 = new Employee(4,"Fran Wilson","franwilson@mail.com","C/ Araquil, 67, Madrid, Spain","(204) 619-5731");
            Employees.Add(e4);
            Employee e5 = new Employee(5,"Martin Blank","martinblank@mail.com","Via Monte Bianco 34, Turin, Italy","(480) 631-2097");
            Employees.Add(e5);
	    }
        public IList<Employee> ListEmployees()
        {
            return Employees;
        }
        public void AddEmployee(Employee e)
        {
            Employees.Add(e);
        }
        public void RemoveEmployee(Employee e)
        {
            Employees.Remove(e);
        }

    }
}
