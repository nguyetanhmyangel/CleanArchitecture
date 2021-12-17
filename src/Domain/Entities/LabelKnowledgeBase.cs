using CleanArchitecture.Domain.Contracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.Entities
{
    [Table("LabelKnowledgeBases")]
    public class LabelKnowledgeBase : AuditableEntity<int>
    {
        public int KnowledgeBaseId { get; set; }

        public int LabelId { get; set; }

        public virtual KnowledgeBase KnowledgeBase { get; set; }

        public virtual Label Label { get; set; }
    }
}