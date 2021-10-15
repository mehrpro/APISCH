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


        [HttpGet(Name = "PersonsForCompany")]
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

        [HttpGet("{pid}", Name = "PersonByCompanyID")]
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

        [HttpPost]
        public IActionResult CreatePersonforCompany(int companyid, [FromBody] PersonCreateDto model)
        {
            if (model == null)
            {
                _logger.LogError("PersonCreateDto object is null.");
                return BadRequest("Person Model is Null.");
            }

            var resultCompany = _unitOfWork.CompanyRep.GetById(companyid);
            if (resultCompany == null)
            {
                _logger.LogError("Company is not find");
                return NotFound();
            }

            var newPerson = _mapper.Map<Person>(model);
            newPerson.CompanyID_FK = companyid;
            _unitOfWork.PersonRepository.CreatePersonForCompany(companyid, newPerson);
            _unitOfWork.Commit();

            var resultView = _mapper.Map<PersonDto>(newPerson);
            return CreatedAtRoute("PersonByCompanyID", new { pid = resultView.ID, companyid }, resultView);
        }
    }
}
