using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APISCH.Entities
{
    public class Company
    {

        public Company()
        {
            People = new HashSet<Person>();
        }



        [Key]
        [Required]
        public int ID { get; set; }
        [MaxLength(150)]
        [Required]
        public string CompanyTitle { get; set; }


        public virtual ICollection<Person> People { get; set; }
    }
}
