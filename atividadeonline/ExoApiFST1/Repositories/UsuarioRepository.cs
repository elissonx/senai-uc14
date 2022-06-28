using ExoApiFST1.Contexts;
using ExoApiFST1.Interfaces;
using ExoApiFST1.Models;

namespace ExoApiFST1.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ExoApiContext _context;

        public UsuarioRepository(ExoApiContext context)
        {
            _context = context;
        }

        public void Atualizar(int UsId, Usuario usuario)
        {
            Usuario usuarioEncontrado = _context.Usuarios.Find(UsId);

            if (usuarioEncontrado != null)
            {
                usuarioEncontrado.Email = usuario.Email;
                usuarioEncontrado.Senha = usuario.Senha;

                _context.Usuarios.Update(usuarioEncontrado);

                _context.SaveChanges();
            }

        }

        public Usuario BuscarPorId(int UsId)
        {
            return _context.Usuarios.Find(UsId);
        }

        public void Cadastrar(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);

            _context.SaveChanges();
        }

        public void Deletar(int UsId)
        {
            Usuario usuarioEncontrado = _context.Usuarios.Find(UsId);

            _context.Usuarios.Remove(usuarioEncontrado);

            _context.SaveChanges();
        }

        public List<Usuario> Listar()
        {
            return _context.Usuarios.ToList();
        }
        
        public Usuario Login(string email, string senha)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Email == email && x.Senha == senha);
        }
    }
}
