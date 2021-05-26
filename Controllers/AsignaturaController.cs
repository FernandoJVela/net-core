using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers
{
    public class AsignaturaController : Controller
    {
        [Route("Asignatura/Index/{asignaturaId?}")]

        public IActionResult Index(string asignaturaId){
            if(!string.IsNullOrWhiteSpace(asignaturaId)){
                var asignatura =    from asig in _context.Asignaturas
                                    where asig.Id == asignaturaId
                                    select asig;

                return View(asignatura.SingleOrDefault());
            }else{
                return View("Multiasignatura", _context.Asignaturas.ToList());
            }
        }


        public IActionResult MultiAsignatura(){

            var listaAsignatura = _context.Asignaturas.ToList();

            ViewBag.Fecha = DateTime.Now;

            return View(listaAsignatura);
        }

        private EscuelaContext _context;

        public AsignaturaController(EscuelaContext context){
            _context = context;
        }
    }
}