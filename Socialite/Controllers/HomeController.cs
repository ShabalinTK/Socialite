using System.Diagnostics;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Socialite.Models;
using SocialNetwork.Application.Features.Posts.Queries.GetByUserPageId;
using SocialNetwork.MVC.Models.Home;

namespace SocialNetwork.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMediator _mediator;

        public HomeController(ILogger<HomeController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var userPageId = 1;
            var query = new GetByUserPageIdQuery(userPageId);

            var viewModel = new HomeVM
            {
                Feeds = await _mediator.Send(query)
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}