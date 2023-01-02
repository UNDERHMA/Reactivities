using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseAPIController : ControllerBase
    {
        
        private IMediator _mediator;

        //Mediator is a propert here, that can be reference from ActivitiesController and other derived controllers
        protected IMediator Mediator => _mediator ??=  
            HttpContext.RequestServices.GetService<IMediator>();
    }
}