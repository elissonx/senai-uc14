using ExoApiFST1.Interfaces;
using ExoApiFST1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExoApiFST1.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioRepository _iUsuarioRrepository;

        public UsuariosController(IUsuarioRepository usuarioRepository)
        {
            _iUsuarioRrepository = usuarioRepository;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(_iUsuarioRrepository.Listar());
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("{UsId}")]
        public IActionResult BuscarPorId(int UsId)
        {
            try
            {
                Usuario usuarioEncontrado = _iUsuarioRrepository.BuscarPorId(UsId);

                if (usuarioEncontrado == null)
                    return NotFound();

                return Ok(usuarioEncontrado);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]

        public IActionResult Cadastrar(Usuario usuario)
        {
            try
            {
                _iUsuarioRrepository.Cadastrar(usuario);

                return StatusCode(201);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut("{UsId}")]

        public IActionResult Alterar(int UsId, Usuario usuario)
        {
            try
            {
                _iUsuarioRrepository.Atualizar(UsId, usuario);

                return Ok("Usuario Alterado");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete("{UsId}")]

        public IActionResult Deletar(int UsId)
        {
            try
            {
                _iUsuarioRrepository.Deletar(UsId);

                return Ok("Usuario Deletado!");
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
