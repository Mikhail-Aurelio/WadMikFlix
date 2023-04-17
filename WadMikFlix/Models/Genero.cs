using System.ComponentModel.DataAnnotations;

namespace WadMikFlix.Models
{
    public class Genero
    {
        public int GeneroId { get; set; }

        [Required]
        public string Nome { get; set; }

        public virtual List<Filme> FilmeId { get; set; }

    }
}
