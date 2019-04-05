using System.Web.Http;
using Applicita.Recruitment.Task2and3.Models;

namespace Applicita.Recruitment.Task2and3.Controllers
{
    public class CustomerController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Post(Customer customer)
        {
            return Ok();
        }
    }
}