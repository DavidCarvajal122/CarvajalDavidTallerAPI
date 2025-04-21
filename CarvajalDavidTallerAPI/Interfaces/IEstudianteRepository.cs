using CarvajalDavidTallerAPI.Models;

namespace CarvajalDavidTallerAPI.Interfaces
{
    public interface IEstudianteRepository
    {
        IEnumerable<Estudiante> DevuelveListadoEstudiante();
        Estudiante DevuelveInformacionEstudiante(string BannerId); 
    }
}
