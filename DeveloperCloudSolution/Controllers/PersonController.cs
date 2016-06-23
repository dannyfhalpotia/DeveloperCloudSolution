using DeveloperCloudSolution.Models;
using System.Web.Http;

namespace DeveloperCloudSolution.Controllers
{
    public class PersonController : BaseController
    {
        // GET: api/person/
        [System.Web.Http.HttpOptions()]
        [System.Web.Http.HttpGet()]
        public IHttpActionResult Get()
        {
            var person = new Person()
            {
                FirstName = "Danny",
                LastName = "Singh",
                Email = "danny.fhalpotia@gmail.com"
            };

            return this.Ok<Models.Person>(person);
        }
    }
}
