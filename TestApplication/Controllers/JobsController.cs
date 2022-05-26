using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestApplication.Models;

namespace TestApplication.Controllers
{
    public class JobsController : ApiController
    {
        IList<Jobs> Jobs = new List<Jobs>()
        {
            new Jobs()
                {
                    id = 101, code = "JOB-01", title = "Project Manager", location = "US Office", department = "Project Management"
                },
                new Jobs()
                {
                    id = 102, code = "JOB-02", title = "Software Developer", location = "India Office",  department = "Software Development"
                },
        };
        public IList<Jobs> GetAllJobs()
        {
            //Return list of all jobs    
            return Jobs;
        } 
        public Jobs GetJobDetails(int id)
        {
            //Return a single job detail    
            var Job = Jobs.FirstOrDefault(e => e.id == id);
            if (Job == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }
            
            return Job;
        }
    }
}
