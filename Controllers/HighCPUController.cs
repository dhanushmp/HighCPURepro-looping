using High_CPU.Models;
using Microsoft.AspNetCore.Mvc;

namespace High_CPU.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HighCPUController : Controller
    {
        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreateValue([FromBody] HighCPUdetails HighCPU)
        {
            string name  = HighCPU.Value;
            var nloop = HighCPU.numberloop;
            int count = 0;
            if (name != null)
            {
                for (int i = 0; i < nloop ; i++)
                {
                   name += "Mindtree";
                
                }
                

            }
            return Ok(name);
        }
    }
}
