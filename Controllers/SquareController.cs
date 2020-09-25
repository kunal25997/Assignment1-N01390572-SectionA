using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_5101_A.Controllers
{
    public class SquareController : ApiController
    {
        public int GET(int id)
        {
            int a = id * id;
            return a;  

        }
    }
}
