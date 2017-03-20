using Abp.AutoMapper;
using EASY.Crud.Entity.Model;

namespace EASY.Crud.Entity.ViewModel
{
    [AutoMap(typeof(BankInfo))]
    public class VmBankInfo : VmBaseInfo
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Bank { get; set; }
        public string Agency { get; set; }
        public string Account { get; set; }
        public AccountType AccountType { get; set; }
    }
}