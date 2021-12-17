using System.ComponentModel.DataAnnotations;
using CleanArchitecture.Domain.Contracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Entities
{
    [Table("Reports")]
    public class Report :AuditableEntity<int>
    {
        public int KnowledgeBaseId { get; set; }

        [MaxLength(500)]
        public string Content { get; set; }

        public bool IsProcessed { get; set; }

        public virtual KnowledgeBase KnowledgeBase { get; set; }
    }
}