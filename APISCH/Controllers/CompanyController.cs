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
    [Route("api/company")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly UnitOfWork<ApplicationContext> _unitOfWork;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public CompanyController(UnitOfWork<ApplicationContext> unitOfWork, ILoggerManager logger,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetCompanies()
        {
            var resultGet = _unitOfWork.CompanyRep.GetAll();
            var result = _mapper.Map<IEnumerable<CompanyDto>>(resultGet);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetCompanyById(int id)
        {
            var result = _unitOfWork.CompanyRep.GetById(id);
            if (result == null)
            {
                _logger.LogInfo($"Not Found CompanyID {id}");
                return NotFound();
            }

            var res = _mapper.Map<CompanyDto>(result);
            return Ok(res);
        }
    }
}
