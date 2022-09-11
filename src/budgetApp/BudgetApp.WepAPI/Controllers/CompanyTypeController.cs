using BudgetApp.Application.Features.CompanyTypes.Commands.CreateCompanyType;
using BudgetApp.Application.Features.CompanyTypes.Queries.GetAllCompanyTypes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BudgetApp.WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyTypeController : BaseController
    {

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] GetListCompanyTypesQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCompanyType([FromBody] CreateCompanyTypeCommand companyTypeCommand)
        {
            var result = await Mediator.Send(companyTypeCommand);
            return Ok(result);
        }


    }
}
