using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;

namespace Anjali_ASP_Assignment1.Controllers
{
    public class InputController : ApiController
    {
        [HttpGet]
        [Route("api/AddTen/{id}")]
        public int AddTen(int id)
        {
            int a = id + 10;
            return a;
        }

        [HttpGet]
        [Route("api/Square/{id}")]
        public int Square(int id)
        {
            int b = id * id;
            return b;
        }

        [HttpPost]
        [Route("api/Greeting")]
        public string Greeting()
        {
            return "Hello World";

        }

        [HttpGet]
        [Route("api/Greeting/{id}")]
        public string Greeting(string id)
        {
            return "Greetings to " + id + " people!";
        }

        [HttpGet]
        [Route("api/NumberMachine/{id}")]
        public float NumberMachine(float id)
        {
            float a = ((id * id) / (id + id)) - id;
            return a;

        }

        [HttpGet]
        [Route("api/HostingCost/{id}")]
        public string HostingCost(double id)
        {
            double costPerDay = (5.50 * id) / 14;
            double afterAddingHST = costPerDay * (13 / 100);
            double Total = costPerDay + afterAddingHST;

            string string1 = id + " fortnights at $5.50/FN = $" + costPerDay + " CAD || ";
            string string2 = " HST 13% = $" + afterAddingHST + " CAD || ";
            string string3 = " Total = $" + Total + " CAD.";

            return (string1 + string2 + string3);
        }

    }

}
