using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_5101_A.Controllers
{
    public class AddTenController : ApiController
    {
        //AddTen/Get/Api/21
        public int GET(int id)
        {
            int a = 10;
            a = id + 10;
            return a;
        }
            
    }


}
