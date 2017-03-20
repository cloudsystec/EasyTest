using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EASY.Crud.Entity.Model
{
    [Table("BankInfos")]
    public class BankInfo : BaseInfo
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Cpf { get; set; }

        [Required]
        public string Bank { get; set; }

        [Required]
        public string Agency { get; set; }

        [Required]
        public string Account { get; set; }

        [Required]
        public AccountType AccountType { get; set; }
    }
}