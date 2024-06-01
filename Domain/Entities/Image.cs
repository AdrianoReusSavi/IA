using System.ComponentModel.DataAnnotations;
using IA.Entities.Common;

namespace IA.Entities
{
    public class Image : BaseEntity<int>
    {
        [Required]
        public required string Base64 { get; set; }
    }
}