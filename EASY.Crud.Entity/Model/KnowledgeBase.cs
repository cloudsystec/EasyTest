using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EASY.Crud.Entity.Model
{
    [Table("KnowledgeBases")]
    public class KnowledgeBase : BaseInfo
    {
        [Required]
        public string Name { get; set; }
    }
}