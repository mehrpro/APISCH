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
    [Route("importexport")]
    [ApiController]
    public class ImportExportController : ControllerBase
    {
        private readonly UnitOfWork<ApplicationContext> _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;

        public ImportExportController(UnitOfWork<ApplicationContext> unitOfWork, IMapper mapper, ILoggerManager logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAllRegister()
        {

            var result = _unitOfWork.ImportExportRepository.GetAll();

            var result2 = _mapper.Map<IEnumerable<ImportExportDto>>(result);
            _logger.LogInfo("GetallRegister");

            //throw new Exception("Exception");

            return Ok(result2);
        }

        //[HttpGet]
        //public IActionResult AllPersons()
        //{
        //    var result = _unitOfWork.PersonRepository.GetAllPersons();
        //    _logger.LogInfo("AllPersons");
        //    return Ok(result);
        //}

        [HttpGet("{id}")]
        public IActionResult GetTag(long id)
        {
            var result = _unitOfWork.ImportExportRepository.GetById(id);
            if (result == null)
            {
                _logger.LogInfo($"تگ با شناسه {id} در بانک یافت نشد");
                return NotFound();
            }

            return Ok(result);
        }
    }
}
