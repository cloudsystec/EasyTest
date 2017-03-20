using System;
using Abp.AutoMapper;
using EASY.Crud.Entity.Model;

namespace EASY.Crud.Entity.ViewModel
{
    [AutoMap(typeof(Knowledge))]
    public class VmKnowledge : VmBaseInfo
    {
        public int Points { get; set; }
        public int KnowledgeBaseId { get; set; }
        public virtual VmKnowledgeBase KnowledgeBase { get; set; }
        public Guid PersonId { get; set; }
    }
}
