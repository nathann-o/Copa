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
    //Para possibilitar a injeção de dependencias
    public class SelecoesController : Controller
    {
        private readonly Contexto _contexto;

        public SelecoesController(Contexto contexto)
        {
            _contexto = contexto;
        }

        //Retorna lista com os nomes das seleções cadastradas no banco para serem listadas pelo DropDownList na View Index
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

        //Cria as seleções
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
                //Caso os dados sejam válidos, são salvos no BD
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            //caso os dados sejam invalidos, retorna a view para serem corrigidos
            else return View(selecao);
        }




        //Apaga as seleções
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
                //Caso o ID não seja nulo, a seleção correspondente é removida do BD e os novos dados são salvos
                _contexto.Remove(selecao);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            else return NotFound(); 
        }
        

    }
}
