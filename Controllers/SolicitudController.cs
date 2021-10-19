using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Practica03_Teoria.Data;
using Practica03_Teoria.Models;

namespace Practica03_Teoria.Controllers
{
    public class SolicitudController : Controller 
    {

         private readonly ApplicationDbContext _context;

        public SolicitudController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Registro(){
             
            var categorias = _context.DataCategorias.ToList();
            ViewBag.items = categorias;

            return View();

        }

         [HttpPost]
        public IActionResult Registro(Solicitudes solicitud , int datos){
            
           

            if(ModelState.IsValid){
                
                 var categoria = _context.DataCategorias.Find(datos);
                 solicitud.Categorias = categoria;
                _context.Add(solicitud);
                _context.SaveChanges();
                return RedirectToAction("Listar");
            }

             var categorias = _context.DataCategorias.ToList();
            ViewBag.items = categorias;

            return View(solicitud);
        }

         public IActionResult Listar(){
            
            var fecha = DateTime.Now;
            var dia = fecha.Day - 5;
            var mes = fecha.Month;
            var año = fecha.Year;
            var solicitudes = _context.DataSolicitudes.Include(s => s.Categorias).Where(b => b.fecha.Day >= dia && b.fecha.Month == mes && b.fecha.Year == año).ToList();
    

            return View(solicitudes);

        }
        
    }
}