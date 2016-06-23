using System.Web.Http;
using System.Web.Http.Cors;

namespace DeveloperCloudSolution.Controllers
{
    //Only allow CORS from below domain
    [EnableCors(origins: "http://developercloudchallenge.azurewebsites.net", headers: "*", methods: "*")]
    public abstract class BaseController : ApiController
    { }
}
