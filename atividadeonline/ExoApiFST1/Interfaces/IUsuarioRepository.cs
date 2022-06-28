using ExoApiFST1.Models;

namespace ExoApiFST1.Interfaces
{
    public interface IUsuarioRepository
    {
        List<Usuario> Listar();

        Usuario BuscarPorId(int UsId);

        void Cadastrar(Usuario usuario);

        void Atualizar(int UsId, Usuario usuario);

        void Deletar(int UsId);

        Usuario Login(string email, string senha);
    }
}
