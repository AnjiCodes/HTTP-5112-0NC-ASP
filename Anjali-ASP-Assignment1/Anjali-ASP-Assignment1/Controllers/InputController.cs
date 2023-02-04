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

        /// <summary>
        /// The following function will return the addition to 10 for the number passed as the parameter.
        /// </summary>
        /// <param name="id">Number that function will return id + 10 for </param>
        [HttpGet]
        [Route("api/AddTen/{id}")]
        public int AddTen(int id)
        {
            int a = id + 10;
            return a;
        }

        /// <summary>
        /// The following function will return square for the number passed as the parameter.
        /// </summary>
        /// <param name="id">Number that function will return square for</param>
        [HttpGet]
        [Route("api/Square/{id}")]
        public int Square(int id)
        {
            int b = id * id;
            return b;
        }

        /// <summary>
        /// The following function will post the string message.
        /// </summary>
        [HttpPost]
        [Route("api/Greeting")]
        public string Greeting()
        {
            return "Hello World";

        }

        /// <summary>
        /// The following function will return the number of people (id) for the number passed as the parameter.
        /// </summary>
        /// <param name="id">Number that function will return id no. of people </param>

        [HttpGet]
        [Route("api/Greeting/{id}")]
        public string Greeting(string id)
        {
            return "Greetings to " + id + " people!";
        }

        /// <summary>
        /// The following function will return the Math Problem of Add,Sub,Div,Mul for the number passed as the parameter.
        /// </summary>
        /// <param name="id">Number that function will return id solution for the Math Problem for </param>

        [HttpGet]
        [Route("api/NumberMachine/{id}")]
        public float NumberMachine(float id)
        {
            float a = ((id * id) / (id + id)) - id;
            return a;

        }

        /// <summary>
        /// The following function will return the number of days in a hotel for number passed as the parameter.
        /// </summary>
        /// <param name="id">Number that function will return the number of days </param>

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
