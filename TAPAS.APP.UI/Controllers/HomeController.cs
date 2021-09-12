using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TAPAS.APP.UI.DataStore;
using TAPAS.APP.UI.Models;

namespace TAPAS.APP.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper _mapper;

        public HomeController(ILogger<HomeController> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            var userName = (string)TempData.Peek("LoggedInUser");
            var User = DataStore.UserServiceClient.RegisteredUsers.AsQueryable().Where(q => q.UserName.Equals(userName)).FirstOrDefault();

            var userDetailVM = _mapper.Map<UserDetailsViewModel>(User);

            return View("Dashboard", new DashboardViewModel() { User = userDetailVM });
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
