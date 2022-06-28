using System.ComponentModel.DataAnnotations;

namespace ExoApiFST1.Models
{
    public class Usuario
    {
        [Key]
        public int UsId { get; set; }

        public string? Email { get; set; }

        public string? Senha { get; set; }

    }
}
