using Microsoft.AspNetCore.Mvc;
using RateMyFood.MVC.Models;
using RateMyFood.MVC.ViewModels;
using System.Diagnostics;

namespace RateMyFood.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IPieRepository pieRepository, ILogger<HomeController> logger)
        {
            _pieRepository = pieRepository;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var piesOfTheWeek = _pieRepository.PiesOfTheWeek;
            var homeViewModel = new HomeViewModel(piesOfTheWeek);
            return View(homeViewModel);

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