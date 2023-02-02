using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_Assignment_01.Controllers
{
    public class AssignmentOneController : ApiController
    {
        /// <summary>
        /// 1) A simple calculator app that adds 10 to input.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// Returns 10 more than the integer input {id}.
        /// </returns>
        /// <example>
        /// GET: api/AddTen/21 --> 31
        /// GET: api/AddTen/0 --> 10
        /// GET: api/AddTen/-9 --> 1
        /// </example>
        [HttpGet]
        [Route("api/AddTen/{id}")]
        public int AddTen(int id)
        {
            return id + 10;
        }

        /// <summary>
        /// 2) A simple calculator app that squares an input.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// Returns the square of the integer input {id}.
        /// </returns>
        /// <example>
        /// GET: api/Square/4 --> 16
        /// GET: api/Square/-5 --> 25
        /// </example>
        [HttpGet]
        [Route("api/Square/{id}")]
        public int Square(int id)
        {
            return id * id;
        }

        /// <summary>
        /// 3) A simple app that returns the string "Hello World!"
        /// </summary>
        /// <returns>
        /// Returns the string “Hello World!”
        /// </returns>
        /// <example>
        /// POST: api/Greeting --> "Hello World!"
        /// </example>
        [HttpPost]
        [Route("api/Greeting")]
        public string Greeting()
        {
            return "Hello World!";
        }

        /// <summary>
        /// 4) A simple app that returns the string "Greetings to X people!" given int input.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// Returns the string “Greetings to {id} people!” where id is an integer value.
        /// </returns>
        /// <example>
        /// GET: api/Greeting/4 --> "Greetings to 3 people!"
        /// GET: api/Greeting/6 --> "Greetings to 6 people!"
        /// GET: api/Greeting/0 --> "Greetings to 0 people!"
        /// </example>
        [HttpGet]
        [Route("api/Greeting/{id}")]
        public string Greeting(int id)
        {
            return "Greetings to " + id.ToString() + " people!;";
        }

        /// <summary>
        /// 5) Create a method which has an input {id}, and applies four mathematical operations to it.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// Returns int with 4 mathematical operations (*,/,+,-) applied to initial input (id).
        /// </returns>
        /// <example>
        /// GET: api/NumberMachine/10 --> 10
        /// GET: api/NumberMachine/-25 --> -25
        /// </example>
        [HttpGet]
        [Route("api/NumberMachine/{id}")]
        public int NumberMachine(int id)
        {
            return id * id / id + id - id;
        }

        [HttpGet]
        [Route("api/HostingCost/{id}")]
        //Question 6 : Initiative Question
        //Note: Initiative questions are more challenging than regular questions.If you cannot solve the entire question, that’s okay! Describe your approach to the problem using comments.
        
        //Charge = $5.50/fortnight
        //HST = 13%
        //{id} number of days elapsed
        //Output: 3 strings describing total cost

        //create a variable fn (fortnight) = 14 (days)
        //as long as id >= 1*fn, charge is 5.5 * 1
        //if id > 1*fn || id <= 2*fn, charge is 5.5 * 2, and so on...
        //there may need to be a loop that increments id and tracks how what the corresponding fn is...
        public double HostingCost(double id)
        {

            double hst = 1.13;
            double charge = 5.5;
            double fn = 14;
            if (id <= (1*fn))
            {
                return (hst * charge);
            } else if (id > (1*fn) || id <= (2*fn))
            {
                return (charge * 2) * hst;
            } else if (id > (2*fn) || id <= (3*fn))
            {
                return (charge *3) * hst;
            } //this should be done using a loop
        }
    }
}
