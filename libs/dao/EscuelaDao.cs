using libs.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace libs.dao
{
    public class EscuelaDao : IEscuelaDao
    {
        MyContext myContext = new MyContext();
        public Alumno Alumno(int code)
        {
            var user= myContext.Alumnos.Find(code);

            return user;
        }

        public Asignatura Asignatura(int code)
        {
            throw new NotImplementedException();
        }

        public void DeleteAlumno(int code)
        {
            throw new NotImplementedException();
        }

        public void DeleteAsignatura(int code)
        {
            throw new NotImplementedException();
        }

        public void DeleteExpediente(int code)
        {
            throw new NotImplementedException();
        }

        public void DeleteGrupo(int code)
        {
            throw new NotImplementedException();
        }

        public void DeleteProfesor(int code)
        {
            throw new NotImplementedException();
        }

        public Expediente Expediente(int code)
        {
            throw new NotImplementedException();
        }

        public Grupo Grupo(int code)
        {
            throw new NotImplementedException();
        }

        public ICollection<Alumno> ListAlumno()
        {
            throw new NotImplementedException();
        }

        public ICollection<Asignatura> ListAsignatura()
        {
            throw new NotImplementedException();
        }

        public ICollection<Expediente> ListExpediente()
        {
            throw new NotImplementedException();
        }

        public ICollection<Grupo> ListGrupo()
        {
            throw new NotImplementedException();
        }

        public ICollection<Profesor> ListProfesor()
        {
            throw new NotImplementedException();
        }

        public Profesor Profesor(string code)
        {
            throw new NotImplementedException();
        }

        public Profesor Profesor(int code)
        {
            throw new NotImplementedException();
        }

        public void SetAlumno( List<Alumno> alumnos)
        {

            myContext.Alumnos.AddRange(alumnos.ToArray());
            myContext.SaveChanges();

            alumnos.ForEach(x => {
                var expediente = new Expediente();
                expediente.Id = x.Id;
                myContext.Add(expediente);
                x.Expediente = expediente;
                myContext.Update(x);
                myContext.SaveChanges();
                
            });
          
            
        }

        public void SetAsignatura( List<Asignatura> asignaturas )
        {
            myContext.Asignaturas.AddRange(asignaturas.ToArray()); ;
            myContext.SaveChanges();          
            
        }

       

        public void SetGrupo(Grupo grupo)
        {
            throw new NotImplementedException();
        }

        public void SetProfesor(List<Profesor> profesors)
        {

            myContext.AddRange(profesors.ToArray());

            myContext.SaveChanges();

        }

        public void UpdateAlumno(string code)
        {
            throw new NotImplementedException();
        }

        public void UpdateAlumno(int code)
        {
            throw new NotImplementedException();
        }

        public void UpdateAsignatura(string code)
        {
            throw new NotImplementedException();
        }

        public void UpdateAsignatura(int code)
        {
            throw new NotImplementedException();
        }

        public void UpdateExpediente(string code)
        {
            throw new NotImplementedException();
        }

        public void UpdateExpediente(int code)
        {
            throw new NotImplementedException();
        }

        public void UpdateGrupo(string code)
        {
            throw new NotImplementedException();
        }

        public void UpdateGrupo(int code)
        {
            throw new NotImplementedException();
        }

        public void UpdateProfesor(string code)
        {
            throw new NotImplementedException();
        }

        public void UpdateProfesor(int code)
        {
            throw new NotImplementedException();
        }
    }
}
