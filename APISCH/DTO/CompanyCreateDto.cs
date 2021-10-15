using System.Collections.Generic;

namespace APISCH.DTO
{
    public class CompanyCreateDto
    {
        public string CompanyTitle { get; set; }
        public IEnumerable<PersonCreateDto> Persons { get; set; }

    }
}