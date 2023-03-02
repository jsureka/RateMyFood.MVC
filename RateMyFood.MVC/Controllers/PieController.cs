﻿using Microsoft.AspNetCore.Mvc;
using RateMyFood.MVC.Models;
using RateMyFood.MVC.ViewModels;

namespace RateMyFood.MVC.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {

            PieListViewModel pieListViewModel = new PieListViewModel(_pieRepository.AllPies, "Cheese Cakes");
            return View(pieListViewModel);
        }

        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            if(pie == null)
            {
                return NotFound();
            }
            return View(pie);

        }
    }
}
