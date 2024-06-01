using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace IA.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImageController : ControllerBase
    {
        private readonly ILogger<ImageController> _logger;

        public ImageController(ILogger<ImageController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    await Request.Body.CopyToAsync(ms);
                    byte[] imageData = ms.ToArray();

                    if (imageData == null || imageData.Length == 0)
                    {
                        _logger.LogInformation("Vazio");
                        return BadRequest("Vazio");
                    }
                    if (!IsImage(imageData))
                    {
                        _logger.LogInformation("Erro");
                        return BadRequest("Erro");
                    }
                    _logger.LogInformation("Sucesso");

                    return Ok("Sucesso");
                }
            }
            catch (Exception ex)
            {
                _logger.LogInformation("Erro exceção");
                return StatusCode(500, "Erro exceção");
            }
        }

        private bool IsImage(byte[] imageData)
        {
            if (imageData.Length < 4)
            {
                return false;
            }
            else if (imageData[0] == 0xFF && imageData[1] == 0xD8 && (imageData[2] == 0xFF && imageData[3] == 0xE0 || imageData[2] == 0xFF && imageData[3] == 0xE1))
            {
                return true; // É um JPEG
            }
            else if (imageData[0] == 0x89 && imageData[1] == 0x50 && imageData[2] == 0x4E && imageData[3] == 0x47)
            {
                return true; // É um PNG
            }
            else if (imageData[0] == 0x47 && imageData[1] == 0x49 && imageData[2] == 0x46 && imageData[3] == 0x38)
            {
                return true; // É um GIF
            }
            else
            { 
                return false;
            }
        }
    }
}