using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestApplication.Models;

namespace TestApplication.Controllers
{
    public class DepartmentsController : ApiController
    {
        IList<Departments> Departments = new List<Departments>()
        {
            new Departments()
                {
                    id = 2085, title = "Software Development"
                },
                new Departments()
                {
                    id = 2086, title = "HR"
                },
        };
        public IList<Departments> GetAllDepartments()
        {
            //Return list of all Departments    
            return Departments;
        }
        public Departments GetDepartmentDetails(int id)
        {
            //Return a single Department detail    
            var Department = Departments.FirstOrDefault(e => e.id == id);
            if (Department == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return Department;
        }
    }
}
