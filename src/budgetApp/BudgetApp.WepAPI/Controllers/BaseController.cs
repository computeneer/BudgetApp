using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BudgetApp.WepAPI.Controllers
{

    public class BaseController : ControllerBase
    {
        private readonly IHttpContextAccessor _contextAccessor;
        protected IMediator? Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
        private IMediator? _mediator;
    }
}
