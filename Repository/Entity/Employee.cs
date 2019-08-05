using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public Employee (int id, string name, string email, string address, string phone)
	    {
            Id= id;
            Name = name;
            Email = email;
            Address = address;
            Phone = phone;
	    }
    }
}
