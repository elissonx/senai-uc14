using ExoApiFST1.Models;
using ExoApiFST1.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExoApiFST1.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]
    
    [ApiController]
    public class ProjetoController : ControllerBase
    {
        private readonly ProjetoRepository _projetoRepository;

        public ProjetoController(ProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(_projetoRepository.Listar());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpGet("{ProjId}")]
        public IActionResult BuscarPorId(int ProjId)
        {
            try
            {
                Projeto projeto = _projetoRepository.BuscarPorId(ProjId);

                if (projeto == null)
                {
                    return NotFound();
                }
                return Ok(projeto);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public IActionResult Cadastrar(Projeto projeto)
        {
            try
            {
                _projetoRepository.Cadastrar(projeto);

                return StatusCode(201);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut("{ProjId}")]
        public IActionResult Atualizar(int ProjId, Projeto projeto)
        {
            try
            {
                _projetoRepository.Atualizar(ProjId, projeto);

                return StatusCode(204);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete("{ProjId}")]
        public IActionResult Deletar(int ProjId)
        {
            try
            {
                _projetoRepository.Deletar(ProjId);

                return StatusCode(204);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
