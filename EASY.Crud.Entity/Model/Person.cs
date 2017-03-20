using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EASY.Crud.Entity.Model
{
    [Table("Persons")]
    public class Person : BaseInfo<Guid>
    {
        public Person()
        {
            Id = Guid.NewGuid();
        }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Skype { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string HourlySalary { get; set; }

        public string MoreLanguages { get; set; }
        public string Linkedin { get; set; }
        public string Portifolio { get; set; }
        public string CrudLink { get; set; }
        
        public BestTime BestTime { get; set; }
        public Disponibility Disponibility { get; set; }

        public virtual ICollection<Knowledge> Knowledges { get; set; }

        [Required]
        public int BankInfoId { get; set; }
        public virtual BankInfo BankInfo { get; set; }
    }
}
