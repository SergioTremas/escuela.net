using libs.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace libs.dao
{
    public interface IEscuelaDao
    {
        public ICollection<Alumno> ListAlumno();
        public ICollection<Asignatura> ListAsignatura();
        public ICollection<Expediente> ListExpediente();

        public ICollection<Grupo> ListGrupo();
        public ICollection<Profesor> ListProfesor();

        public Alumno Alumno(int code);
        public Asignatura Asignatura(int code);
        public Expediente Expediente(int code);

        public Grupo Grupo(int code);
        public Profesor Profesor(int code);

        public void DeleteAlumno(int code);
        public void DeleteAsignatura(int code);
        public void DeleteExpediente(int code);

        public void DeleteGrupo(int code);
        public void DeleteProfesor(int code);

        public void UpdateAlumno(int code);
        public void UpdateAsignatura(int code);
        public void UpdateExpediente(int code);

        public void UpdateGrupo(int code);
        public void UpdateProfesor(int code);

        public void SetAlumno( List<Alumno> alumnos);
        public void SetAsignatura( List<Asignatura> asignaturas);
       
        public void SetGrupo(Grupo grupo);
        public void SetProfesor( List<Profesor> profesores);


    }
}
