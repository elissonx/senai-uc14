using ChapterFST1.Models;
using ChapterFST1.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChapterFST1.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]

    [ApiController]

    //[Authorize] //autorização para acesso
    public class LivroController : ControllerBase
    {
        private readonly LivroRepository _livroRepository;

        public LivroController(LivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(_livroRepository.Listar());
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        //aula 28/04/2022

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            try
            {
                Livro livro = _livroRepository.BuscarPorId(id);

                if (livro == null)
                {
                    return NotFound();
                }
                return Ok(livro);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public IActionResult Cadastrar(Livro livro)
        {
            try
            {
                _livroRepository.Cadastrar(livro);

                return StatusCode(201);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Livro livro)
        {
            try
            {
                _livroRepository.Atualizar(id, livro);

                return StatusCode(204);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                _livroRepository.Deletar(id);

                return StatusCode(204);

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
