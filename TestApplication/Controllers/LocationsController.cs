using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestApplication.Models;

namespace TestApplication.Controllers
{
    public class LocationsController : ApiController
    {
        IList<Locations> Locations = new List<Locations>()
        {
            new Locations()
                {
                    id = 10030, title = "US Head Office", city= "Baltimore", state = "MD", country = "United Sates", zip = 21202
                },
        };
        public IList<Locations> GetAllLocations()
        {
            //Return list of all Locations    
            return Locations;
        }
        public Locations GetLocationDetails(int id)
        {
            //Return a single Location detail    
            var Location = Locations.FirstOrDefault(e => e.id == id);
            if (Location == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return Location;
        }
    }
}