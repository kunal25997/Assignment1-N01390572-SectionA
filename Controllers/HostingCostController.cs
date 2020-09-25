using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;

namespace Assignment1_5101_A.Controllers
{
    public class HostingCostController : ApiController
    {
        //HostingCost/api
        public int GET(int id)
        {
            decimal cost = (decimal)5.50;
            cost = Math.Round(cost);

            decimal fn = (decimal)14 * cost;
            fn = Math.Round(fn);

            decimal tax = (decimal)cost * 13 / 100;
            tax = Math.Round(tax);

            decimal total = (decimal)tax + cost;
            total = Math.Round(total);

            return (int)(total);
        }
    }
}
