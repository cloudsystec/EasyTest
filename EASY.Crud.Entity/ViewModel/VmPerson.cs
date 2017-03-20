using System;
using System.Collections.Generic;
using Abp.AutoMapper;
using EASY.Crud.Entity.Model;

namespace EASY.Crud.Entity.ViewModel
{
    [AutoMap(typeof(Person))]
    public class VmPerson : VmBaseInfo<Guid>
    {
        public VmPerson()
        {
            Id = Guid.NewGuid();
        }
        
        public string Name { get; set; }
        public string Email { get; set; }
        public string Skype { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string HourlySalary { get; set; }
        public string MoreLanguages { get; set; }
        public string Linkedin { get; set; }
        public string Portifolio { get; set; }
        public string CrudLink { get; set; }
        
        public BestTime BestTime { get; set; }
        public Disponibility Disponibility { get; set; }
        public virtual ICollection<VmKnowledge> Knowledges { get; set; }
        public int BankInfoId { get; set; }
        public virtual VmBankInfo BankInfo { get; set; }
    }
}
