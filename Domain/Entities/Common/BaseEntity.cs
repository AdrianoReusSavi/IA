using System.ComponentModel.DataAnnotations;

namespace IA.Entities.Common
{
    public class BaseEntity<T>
    {
        [Key]
        public T? Id { get; set; }
        public bool Ativo { get; set; }
    }
}