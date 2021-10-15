using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APISCH.Entities
{
    public class Person : BaseClass<string>
    {
        public Person()
        {
            ID = Guid.NewGuid().ToString();
            IsActive = true;
            RegisterTime = DateTime.Now;
        }


        [Required]
        [MaxLength(100)]
        public string FName { get; set; }
        [Required]
        [MaxLength(100)]
        public string LName { get; set; }
        public byte Age { get; set; }
        [StringLength(10, ErrorMessage = "String Length 10 Number - No Zero Set")]
        public string PhoneNumber { get; set; }


        public int CompanyID_FK { get; set; }
        [ForeignKey("CompanyID_FK")]
        public Company Company { get; set; }
    }
}