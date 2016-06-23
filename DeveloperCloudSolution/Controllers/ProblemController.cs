using DeveloperCloudSolution.Utilities;
using System.Web.Http;

namespace DeveloperCloudSolution.Controllers
{
    public class ProblemController : BaseController
    {
        // GET: api/Problem/5
        [HttpOptions()]
        [HttpGet()]
        public IHttpActionResult Get(int number)
        {
            return Ok<bool>(FibonacciHelper.IsFibonacciNumber(number));
        }
    }
}
