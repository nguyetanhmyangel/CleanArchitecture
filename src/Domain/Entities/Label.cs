using System.ComponentModel.DataAnnotations;
using CleanArchitecture.Domain.Contracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Entities
{
    [Table("Labels")]
    public class Label : AuditableEntity<int>
    {
        [MaxLength(50)]
        public string Name { get; set; }
    }
}