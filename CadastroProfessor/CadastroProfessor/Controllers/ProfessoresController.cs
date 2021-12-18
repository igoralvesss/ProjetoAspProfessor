using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroProfessor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CadastroProfessor.Controllers
{
    public class ProfessoresController : Controller
    {
        private readonly Contexto _contexto;

        public ProfessoresController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _contexto.Professores.ToListAsync());
        }

        [HttpGet]
        public IActionResult CriarProfessor()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CriarProfessor(Professor professor)
        {
            if (ModelState.IsValid)
            {
                _contexto.Add(professor);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            else return View(professor);
        }
    }
}
