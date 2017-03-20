using Abp.AutoMapper;
using EASY.Crud.Entity.Model;

namespace EASY.Crud.Entity.ViewModel
{
    [AutoMap(typeof(KnowledgeBase))]
    public class VmKnowledgeBase : VmBaseInfo
    {
        public string Name { get; set; }
    }
}