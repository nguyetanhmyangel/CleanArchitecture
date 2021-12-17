using CleanArchitecture.Domain.Contracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Entities
{
    [Table("Votes")]
    public class Vote : AuditableEntity<int>
    {
        public int KnowledgeBaseId { get; set; }

        public virtual KnowledgeBase KnowledgeBase { get; set; }
    }
}