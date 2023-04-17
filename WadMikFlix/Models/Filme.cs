using System.ComponentModel.DataAnnotations;

namespace WadMikFlix.Models
{
    public class Filme
    {
        public int FilmeId { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public int Classificacao { get; set; }

        public int GeneroId { get; set; }
        public virtual Genero Genero { get; set; }
    }
}
