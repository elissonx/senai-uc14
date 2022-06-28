using ExoApiFST1.Contexts;
using ExoApiFST1.Models;

namespace ExoApiFST1.Repositories
{
    public class ProjetoRepository
    {
        //criação de uma variável privada apenas para leitura

        private readonly ExoApiContext _context; 

        public ProjetoRepository(ExoApiContext context)
        {
            _context = context;
        }

        public List<Projeto> Listar()
        {
            return _context.Projetos.ToList();
        }

        public Projeto BuscarPorId(int ProjId)
        {
            return _context.Projetos.Find(ProjId);
        }

        public void Cadastrar(Projeto projeto
            )
        {
            _context.Projetos.Add(projeto);

            _context.SaveChanges();

        }

        public void Atualizar(int ProjId, Projeto projeto)
        {
            Projeto projetoBuscado = _context.Projetos.Find(ProjId);

            if (projetoBuscado != null)
            {
                projetoBuscado.Titulo = projeto.Titulo;
                projetoBuscado.Estado = projeto.Estado;
                projetoBuscado.DatadeInicio = projeto.DatadeInicio;
                projetoBuscado.Tecnologia = projeto.Tecnologia;
                projetoBuscado.Requisitos = projeto.Requisitos;
                projetoBuscado.Área = projeto.Área;
            }

            _context.Projetos.Update(projetoBuscado);

            _context.SaveChanges();
        }

        public void Deletar(int ProjId)
        {
            Projeto projeto = _context.Projetos.Find(ProjId);

            _context.Projetos.Remove(projeto);

            _context.SaveChanges();
        }
    }
}
