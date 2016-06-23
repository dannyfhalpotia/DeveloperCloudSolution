using DeveloperCloudSolution.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace DeveloperCloudSolution.Controllers
{
    public class ProfileController : BaseController
    {
        // GET: api/profile/
        [System.Web.Http.HttpOptions()]
        [System.Web.Http.HttpGet()]
        public IHttpActionResult Get()
        {
            var profile = new Profile();
            profile.Interests = new List<string>();
            profile.Interests.AddRange(new string[] { "coding", "music", "reading", "weight lifting"});   

            return this.Ok<Models.Profile>(profile);
        }
    }
}
