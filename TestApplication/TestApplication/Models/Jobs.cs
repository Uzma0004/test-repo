using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApplication.Models
{
    public class Jobs
    {
        public int id
        {
            get;
            set;
        }

        public string code
        {
            get;
            set;
        }

        public string title
        {
            get;
            set;
        }
        public string location
        {
            get;
            set;
        }

        public string department
        {
            get;
            set;
        }
    }
}