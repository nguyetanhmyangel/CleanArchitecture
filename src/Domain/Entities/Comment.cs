using System.ComponentModel.DataAnnotations;
using CleanArchitecture.Domain.Contracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Entities
{
    [Table("Comments")]
    public class Comment : AuditableEntity<int>
    {
        [MaxLength(500)]
        [Required]
        public string Content { get; set; }

        [Required]
        public int KnowledgeBaseId { get; set; }

        public virtual KnowledgeBase KnowledgeBase { get; set; }
    }
}