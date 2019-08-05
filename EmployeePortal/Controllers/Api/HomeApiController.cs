using EmployeePortal.App_Start;
using Services.Contracts;
using Services.Models;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;

namespace EmployeePortal.Controllers.Api
{
    public class HomeApiController : ApiController
    {
        IEmployeeService EmployeeService;
        public HomeApiController()
        {
            EmployeeService = Injector.Container.GetInstance<IEmployeeService>();
        }
        // GET: api/HomeApi
        public JsonResult<IList<EmployeeModel>> Get()
        {
            return Json(EmployeeService.ListEmployees());
        }

        // GET: api/HomeApi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/HomeApi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/HomeApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/HomeApi/5
        public void Delete(int id)
        {
        }
    }
}
