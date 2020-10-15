using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Copa.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Copa.Controllers
{
    public class SelecoesController1 : Controller
    {
        private readonly Contexto _contexto;

        public SelecoesController1(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.SelecaoId = new SelectList

                (

                    await _contexto.Selecoes.ToListAsync(),

                    "SelecaoID",

                    "Nome"

                );
            return View(await _contexto.Selecoes.ToListAsync());
        }

        [HttpGet]
        public IActionResult CriarSelecao()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CriarSelecao(Selecao selecao)
        {
            if (ModelState.IsValid)
            {
                _contexto.Add(selecao);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else return View(selecao);
        }

        
        

        
        [HttpGet]
        public IActionResult ExcluirSelecao(int? id)
        {
            if (id != null)
            {
                Selecao selecao = _contexto.Selecoes.Find(id);
                return View(selecao);

            }
            else return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> ExcluirSelecao(int? id, Selecao selecao)
        {
            if (id != null)
            {
                _contexto.Remove(selecao);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            else return NotFound(); 
        }
        

    }
}
