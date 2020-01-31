using libs.dao;
using libs.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace libs.Service
{
    public class EscuelaService : IEscuelaService
    {
        IEscuelaDao escuelaDao;

      

        public EscuelaService(IEscuelaDao escuelaDao)
        {
            this.escuelaDao = escuelaDao;
        }

        public Alumno GetAlumno(int id)
        {
           return  escuelaDao.Alumno(id);
        }

        public void SetAlumno(List<Alumno> alumno)
        {
            escuelaDao.SetAlumno(alumno);
            
        }

        public void SetAsignatura(List<Asignatura> asignatura)
        {
            escuelaDao.SetAsignatura(asignatura);

        }

        public void SetProfesor(List<Profesor> profesor)
        {
            escuelaDao.SetProfesor(profesor);
        }
    }
}
