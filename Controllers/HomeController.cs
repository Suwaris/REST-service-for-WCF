using Microsoft.AspNetCore.Mvc;

namespace DemoRestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        [HttpGet]
        public async Task<string[]> Get()
        {
            ServiceReference1.AuthorServiceClient authorServiceClient = new ServiceReference1.AuthorServiceClient();
            var data = await authorServiceClient.GetAuthorNamesAsync();
            return data;
        }
    }
}
