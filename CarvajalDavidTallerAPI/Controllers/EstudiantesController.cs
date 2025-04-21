using CarvajalDavidTallerAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarvajalDavidTallerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiantesController : ControllerBase
    {
        EstudianteRepository _estudianteRepository; 

        public EstudiantesController()
        {
            _estudianteRepository = new EstudianteRepository(); 
        }

        [HttpGet]
        public IActionResult DevuelveListadoEstudiantes()
        {
            var estudiantes = _estudianteRepository.DevuelveListadoEstudiante();
            return Ok(estudiantes); 
        }

        [Route("infoEstudiante/{BannerId}")]
        [HttpGet]

        public IActionResult GetInformacionEstudiante(string BannerId)
        {
            try
            {
                var infoEstudiante = _estudianteRepository.DevuelveInformacionEstudiante(BannerId);
                return Ok(infoEstudiante);
            }catch (Exception e)
            {
                return NotFound(); 
            }
        }
    }
}
