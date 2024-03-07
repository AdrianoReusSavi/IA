using System.ComponentModel.DataAnnotations;
using IA.Entities.Common;

namespace IA.Entities
{
    public class Produto : BaseEntity<int>
    {
        [Required]
        public required string Nome { get; set; }
        [Required]
        public double Quantidade { get; set; }
    }
}