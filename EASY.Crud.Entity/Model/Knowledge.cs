using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EASY.Crud.Entity.Model
{
    [Table("Knowledges")]
    public class Knowledge : BaseInfo
    {
        [Required]
        public int Points { get; set; }

        [Required]
        public int KnowledgeBaseId { get; set; }
        public virtual KnowledgeBase KnowledgeBase { get; set; }

        [Required]
        public Guid PersonId { get; set; }
    }
}
