using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleREST.Models
{
    public class Person
    {
        public long ID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public double PayRate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


    }
}