using System;

namespace EASY.Crud.Entity.ViewModel
{
    public class VmBaseInfo<T>
    {
        public VmBaseInfo()
        {
            CreatedAt = DateTime.UtcNow;
            IsDeleted = false;
        }

        public T Id { get; set; }

        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class VmBaseInfo : VmBaseInfo<int> { }
}