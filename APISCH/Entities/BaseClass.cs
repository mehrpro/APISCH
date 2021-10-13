using System;
using System.ComponentModel.DataAnnotations;

namespace APISCH.Entities
{
    public class BaseClass<T>
    {
        [Key]
        public T ID { get; set; }
        [Required]
        public DateTime RegisterTime { get; set; }
        [Required]
        public bool IsActive { get; set; }

    }
}