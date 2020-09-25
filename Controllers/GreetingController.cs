using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_5101_A.Controllers
{
    public class GreetingController : ApiController
    {
        //Greeting/api/POST
        public string POST(string id)
        {
            return "Hello World";
        }

        //Greetings to People
        public IEnumerable<string> GET()
        {
            return new String[] { "value1", "value2" };
        }
        public string GET(int id)
        {
            string a = "Hello World to " + id + "" + "People";
            return a;
        }
    }
}
