using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APISCH.DTO;
using APISCH.Entities;
using APISCH.Infrastructure;
using AutoMapper;

namespace APISCH.Controllers
{
    [Route("importexport/[action]")]
    [ApiController]
    public class ImportExportController : ControllerBase
    {
        private readonly UnitOfWork<ApplicationContext> _unitOfWork;
        private readonly IMapper _mapper;

        public ImportExportController(UnitOfWork<ApplicationContext> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllRegiter()
        {

            var result = _unitOfWork.ImportExportRepository.GetAllImportExports();

            var result2 = _mapper.Map<IEnumerable<ImportExportDto>>(result);

            return Ok(result2);
        }

        [HttpGet]
        public IActionResult AllPersons()
        {
            var result = _unitOfWork.PersonRepository.GetAllPersons();
            return Ok(result);
        }
    }
}
