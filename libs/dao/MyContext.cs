using libs.Models;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Text;

namespace libs.dao
{
    public class MyContext : DbContext
    {
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Expediente> Expedientes { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Grupo> Grupos { set; get; }
        public DbSet<Profesor> Profesores {set; get;}
        public DbSet<Clase> Clases {set; get; }
        public DbSet<Matricula> Matriculas { set; get; }


        protected override void OnModelCreating(ModelBuilder builder) //para generar una llave compuesta hay k hacer lo siguiente 
        {
             builder.Entity<Matricula>().HasKey(table => new { table.idExpediente, table.idAlumno });
             builder.Entity<Matricula>()
            .HasOne(s => s.Expediente)
            .WithMany(b => b.Matriculas)
            .HasForeignKey(p => p.idExpediente);

            builder.Entity<Matricula>()
            .HasOne(s => s.Alumno)
            .WithMany(b => b.Matriculas)
            .HasForeignKey(p => p.idAlumno);

            //   .HasKey(table => new { // nombre de la tabla con las llaves compuestas
            //  table.Expediente, // claves 
            //  table.Alumno //clvaves
            // });


        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=Escuela2019;user=Escuela2019;password=Escuela2019;");
                                     
        }
    }
}
