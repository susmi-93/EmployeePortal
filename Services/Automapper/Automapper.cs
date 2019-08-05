using AutoMapper;
using Repository.Entity;
using Services.Models;
using System.Collections.Generic;

namespace Services.Bootstrap
{
    public static class Automapper
    {
        public static IMapper Mapper { get; set; }
        public static void Register()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Employee, EmployeeModel>();
            });

            Mapper = config.CreateMapper();
        }
    }
}