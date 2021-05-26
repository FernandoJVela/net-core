using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace platzi_asp_net_core.Models
{
    public class EscuelaContext: DbContext
    {
        public DbSet<Escuela> Escuelas { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Evaluación> Evaluaciones { get; set; }

        public EscuelaContext (DbContextOptions<EscuelaContext> options): base(options){

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var escuela = new Escuela();
            escuela.AñoDeCreación = 2012;
            escuela.Id = Guid.NewGuid().ToString();
            escuela.Nombre = "Platzi School";
            escuela.Dirección = "Cra 9 No 72 80";
            escuela.Ciudad = "Bogotá";
            escuela.Pais = "Colombia";
            escuela.TipoEscuela = TiposEscuela.Primaria;

            var cursos = cargarCursos(escuela);

            var asignaturas = CargarAsignaturas(cursos);

            var alumnos = CargarAlumnos(cursos);

            modelBuilder.Entity<Escuela>().HasData(escuela);
            modelBuilder.Entity<Curso>().HasData(cursos.ToArray());
            modelBuilder.Entity<Asignatura>().HasData(asignaturas.ToArray());
            modelBuilder.Entity<Alumno>().HasData(alumnos.ToArray());
        }

        private List<Alumno> CargarAlumnos(List<Curso> cursos){
            var listaAlumnos = new List<Alumno>();

            Random rnd = new Random();
            foreach(var curso in cursos){
                int cantRandom = rnd.Next(5,20);
                var tmpList = GenerarAlumnosAlAzar(curso, cantRandom);
                listaAlumnos.AddRange(tmpList);
            }
            return listaAlumnos;
        }

        private static List<Asignatura> CargarAsignaturas(List<Curso> cursos)
        {
            var listaCompleta = new List<Asignatura>();
            foreach (var curso in cursos)
            {                
                var tmpList = new List<Asignatura>{
                    new Asignatura{Nombre="Python", Id = Guid.NewGuid().ToString(), CursoId = curso.Id},
                    new Asignatura{Nombre="Java", Id = Guid.NewGuid().ToString(), CursoId = curso.Id},
                    new Asignatura{Nombre="C++", Id = Guid.NewGuid().ToString(), CursoId = curso.Id},
                    new Asignatura{Nombre="C#", Id = Guid.NewGuid().ToString(), CursoId = curso.Id},
                    new Asignatura{Nombre="JavaScript", Id = Guid.NewGuid().ToString(), CursoId = curso.Id}
                };
                listaCompleta.AddRange(tmpList);
            }
            return listaCompleta;
        }

        private List<Curso> cargarCursos(Escuela escuela)
        {
            var escCursos = new List<Curso>(){
                new Curso() { Id = Guid.NewGuid().ToString(), EscuelaId = escuela.Id, Nombre = "A-1", Jornada = TiposJornada.Mañana },
                new Curso() { Id = Guid.NewGuid().ToString(), EscuelaId = escuela.Id, Nombre = "A-2", Jornada = TiposJornada.Mañana },
                new Curso() { Id = Guid.NewGuid().ToString(), EscuelaId = escuela.Id, Nombre = "B-1", Jornada = TiposJornada.Tarde },
                new Curso() { Id = Guid.NewGuid().ToString(), EscuelaId = escuela.Id, Nombre = "B-2", Jornada = TiposJornada.Tarde },
                new Curso() { Id = Guid.NewGuid().ToString(), EscuelaId = escuela.Id, Nombre = "C-1", Jornada = TiposJornada.Noche },
            };

            return escCursos;
        }

        private List<Alumno> GenerarAlumnosAlAzar(Curso curso, int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos =  from n1 in nombre1
                                from n2 in nombre2
                                from a1 in apellido1
                                select new Alumno {
                                    Nombre = $"{n1} {n2} {a1}",
                                    Id = Guid.NewGuid().ToString(),
                                    CursoId = curso.Id
                                };
            
            return listaAlumnos.OrderBy((al) => al.Id).Take(cantidad).ToList();
        }
    }
}