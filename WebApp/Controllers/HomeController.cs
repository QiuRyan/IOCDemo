using System.Threading.Tasks;
using System.Web.Http;
using IOC.Demo.Lib;

namespace WebApp.Controllers
{
    public class HomeController : ApiController
    {
        private readonly ISchool school;

        public HomeController(ISchool school)
        {
            this.school = school;
        }

        /// <summary>
        /// 测试Autofac和Swagger
        /// </summary>
        /// <returns>Task&lt;IHttpActionResult&gt;.</returns>
        [HttpGet]
        public async Task<IHttpActionResult> Index()
        {
            return this.Ok(await Task.FromResult(this.school.GetUser()));
        }
    }
}