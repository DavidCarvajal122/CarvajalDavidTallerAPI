using CarvajalDavidTallerAPI.Interfaces;
using CarvajalDavidTallerAPI.Models;

namespace CarvajalDavidTallerAPI.Repositories
{
    public class EstudianteRepository : IEstudianteRepository
    {
        public Estudiante DevuelveInformacionEstudiante(string BannerId)
        {
            var estudiantes = DevuelveListadoEstudiante();
            return estudiantes.First(item => item.BannerId == BannerId);
        }

        public IEnumerable<Estudiante> DevuelveListadoEstudiante()
        {
            List<Estudiante> estudiantes = new List<Estudiante>();
            Estudiante estudiante1 = new Estudiante
            {
                BannerId = "12345",
                Nombre = "David",
                Edad = 20,
                TieneBeca = false
            };
            estudiantes.Add(estudiante1);
            Estudiante estudiante2 = new Estudiante
            {
                BannerId = "67890",
                Nombre = "Yoba",
                Edad = 20,
                TieneBeca = true
            };
            estudiantes.Add(estudiante2);
            return estudiantes; 
        }

    }
}
