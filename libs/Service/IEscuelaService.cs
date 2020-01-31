using libs.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace libs.Service
{
    public interface IEscuelaService
    {
        public void SetAlumno( List<Alumno> alumno);
        public void SetAsignatura(List<Asignatura> asignatura);
        public void SetProfesor(List<Profesor> profesor);
        public Alumno GetAlumno(int id);

    }
}
