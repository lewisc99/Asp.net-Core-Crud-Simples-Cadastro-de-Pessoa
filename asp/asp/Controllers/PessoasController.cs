using crud.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud.Controllers
{
    public class PessoasController : Controller
    {

        private readonly Contexto _contexto;


        public PessoasController(Contexto contexto)
        {
            _contexto = contexto;
        }
        public IActionResult Index()
        {
            return View(_contexto.Pessoas.ToList());
        }

        [HttpGet]
        public IActionResult CriarPessoa()
        {
           
            return View(new Pessoa());
        }
        [HttpPost]
        public IActionResult CriarPessoa([FromForm] Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                _contexto.Add(pessoa);
                _contexto.SaveChanges();

                TempData["Mensagem"] = "A Pessoa " + pessoa.Name + " foi cadastrada com sucesso.";

                return RedirectToAction("Index");
            }
            return View(pessoa);



        }

        [HttpGet]
        public IActionResult AtualizarPessoa(int? id)
        {

            if (id!= null)
            {
               
               
                Pessoa pessoa = _contexto.Pessoas.Find(id);
                return View("CriarPessoa", pessoa);
                
            }

            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult AtualizarPessoa(int? id, Pessoa pessoa)
        {

            if (id != null)
            {
                if (ModelState.IsValid)
                {
                    _contexto.Update(pessoa);

                    _contexto.SaveChanges();
                    TempData["Mensagem"] = "A pessoa " + pessoa.Name + " foi atualizada com sucesso";

                    return RedirectToAction("index");


                }
                else
                {
                    return View();
                }
                
            }

            else
            {
                return View(pessoa);
            }
        }

        [HttpGet]
        public IActionResult ExcluirPessoa(int? id)
        {

            if (id != null)
            {
                Pessoa pessoa = _contexto.Pessoas.Find(id);
                return View(pessoa);
            }

            else
            {
                return NotFound();
            }
        }
        [HttpPost]
        public IActionResult ExcluirPessoa(int? id, Pessoa pessoa)
        {

            if (id != null)
            {
                _contexto.Remove(pessoa);

                _contexto.SaveChanges();

                TempData["MensagemError"] = "A Pessoa " + pessoa.Name + " foi removida com sucesso. ";

                return RedirectToAction("index");
            }

            else
            {
                return NotFound();
            }
        }
    }
}
