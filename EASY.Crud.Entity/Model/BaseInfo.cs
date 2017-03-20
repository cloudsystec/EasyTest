using System;
using System.ComponentModel.DataAnnotations;

namespace EASY.Crud.Entity.Model
{
    public class BaseInfo<T>
    {
        public BaseInfo()
        {
            CreatedAt = DateTime.UtcNow;
            IsDeleted = false;
        }

        [Required]
        [Key]
        public T Id { get; set; }

        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class BaseInfo : BaseInfo<int> { }
}