using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APISCH.DTO;
using APISCH.Infrastructure;
using AutoMapper;

namespace APISCH.Controllers
{
    [Route("api/company/{companyid}/person")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly UnitOfWork<ApplicationContext> _unitOfWork;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public PersonController(UnitOfWork<ApplicationContext> unitOfWork, ILoggerManager logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult GetPersonsForCompany(int companyid)
        {
            var resultCompany = _unitOfWork.CompanyRep.GetById(companyid);
            if (resultCompany == null)
            {
                _logger.LogInfo($"Not Found Company");
                return NotFound();
            }

            var result = _unitOfWork.PersonRepository.GetMany(x => x.CompanyID_FK == companyid);
            var resultGet = _mapper.Map<IEnumerable<PersonDto>>(result);
            return Ok(resultGet);
        }

        [HttpGet("{pid}")]
        public IActionResult GetPersonByCompanyID(int companyid, string pid)
        {
            var resultCompany = _unitOfWork.CompanyRep.GetById(companyid);
            if (resultCompany == null)
            {
                _logger.LogInfo("Not Found Company");
                return NotFound();
            }

            var resultPerson = _unitOfWork.PersonRepository.GetById(pid);
            if (resultPerson == null)
            {
                _logger.LogInfo("Not Found Person");
                return NotFound();
            }
            var result = _mapper.Map<PersonDto>(resultPerson);
            return Ok(result);

        }
    }
}
