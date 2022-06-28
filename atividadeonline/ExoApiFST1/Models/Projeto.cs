using System.ComponentModel.DataAnnotations;

namespace ExoApiFST1.Models {
    public class Projeto
    {
        [Key]
        public int ProjId { get; set; }

        public string? Titulo { get; set; }

        public string? Estado { get; set; }

        public DateTime DatadeInicio { get; set; }

        public string? Tecnologia { get; set; }

        public string? Requisitos { get; set; }

        public string? Área { get; set; }

    }
}
