using MediatR;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Application.Features.Event.Queries.GetAllEvents;
using SocialNetwork.MVC.Models.Event;

namespace Socialite.Controllers
{
    public class EventController : Controller
    {
        // GET: EventController
        private readonly IMediator _mediator;
        public EventController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index([FromQuery] string formatType = "offline")
        {
            var query = new GetAllEventsQuery(formatType);
            var model = new EventVM()
            {
                Events = await _mediator.Send(query),
                CurrentFormatType = formatType
            };

            return View(model);
        }
    }
}
