using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class equiposController : ControllerBase
    {
        private readonly equiposContext _equiposContexto;
        
        public equiposController(equiposContext  equiposContexto)
        {
           _equiposContexto = equiposContexto;
        }

        [HttpGet]
        [Route ("GetAll")]

        public IActionResult Get()
        {
            List<equipos> ListadoEquipo = (from e in _equiposContexto.equipos
                                           select e).ToList();
            if (ListadoEquipo.Count() == 0)
            {
                return NotFound();            
            }
            return Ok(ListadoEquipo);
        }

    
    }


}
