using BethanysPieShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PieController : ControllerBase
    {
        private readonly IPieRepository _pieRepository;

        public PieController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_pieRepository.AllPies);
        }

        [HttpGet("{id}")]
        public IActionResult GetPieById(int id)
        {
            return Ok(_pieRepository.GetPieById(id));
        }
    }
}
