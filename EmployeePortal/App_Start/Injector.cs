

using Repository.Contracts;
using Repository.Repository;
using Services.Contracts;
using Services.Service;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using System.Web.Mvc;

namespace EmployeePortal.App_Start
{
    public static class Injector
    {
        public static Container Container { get; set; }

        public static void Initialise()
        {
            Container = new Container();
            Container.Register<IEmployeeService, EmployeeService>();
            Container.Register<IEmployeeRepository, EmployeeRepository>();
            Container.Verify();
            DependencyResolver.SetResolver(
            new SimpleInjectorDependencyResolver(Container));
        }
    }
}