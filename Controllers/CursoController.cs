using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers{
    
    public class CursoController : Controller{
        
        [Route("Curso/Index/{cursoId?}")]

        public IActionResult Index(string cursoId){
            if(!string.IsNullOrWhiteSpace(cursoId)){
                var curso =    from cur in _context.Cursos
                                where cur.Id == cursoId
                                select cur;
                return View(curso.SingleOrDefault());
            }else{
                return View("MultiCurso", _context.Cursos.ToList());
            }
        }

        public IActionResult MultiCurso(){
            var listaCursos = _context.Cursos.ToList();

            ViewBag.Fecha = DateTime.Now;

            return View(listaCursos);
        }

        public IActionResult Create(){

            ViewBag.Fecha = DateTime.Now;

            return View();
        }

        [HttpPost]

        public IActionResult Create(Curso curso){

            ViewBag.Fecha = DateTime.Now;
            if(ModelState.IsValid){
                var escuela = _context.Escuelas.FirstOrDefault();
            
                curso.EscuelaId = escuela.Id;
                _context.Cursos.Add(curso);
                _context.SaveChanges();
                ViewBag.MensajeCursoCreado = "Curso creado exitosamente";
                return View("Index", curso);
            }else{
                return View(curso);
            }
        }

        private EscuelaContext _context;
        
        public CursoController(EscuelaContext context){
            _context = context;
        }
    }
}