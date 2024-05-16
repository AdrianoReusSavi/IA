using IA.Interfaces.Service;
using IA.Entities;
using Microsoft.AspNetCore.Mvc;

namespace IA.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImageController : ControllerBase
    {
        [HttpPost]
        public ActionResult<Image> Post(string imageBase64)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(imageBase64))
                {
                    Console.WriteLine("Vazio!");
                } 
                else 
                {
                    byte[] imageBytes = Convert.FromBase64String(imageBase64);
                }
                
                Console.WriteLine("Susseço!");

                return Ok();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
                return Ok();
            }
        }
    }
}