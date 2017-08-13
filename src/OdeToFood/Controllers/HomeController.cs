using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OdeToFood.Entities;
using OdeToFood.Services;
using OdeToFood.ViewModels;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        public IRestaurantData _restaurantData;
        public IGreeter _greeter;

        public HomeController(IRestaurantData restaurantData, IGreeter greeter)
        {
            _restaurantData = restaurantData;
            _greeter = greeter;
        }
        public IActionResult Index()
        {
            var model = new HomePageViewModel();
            model.Restaurants = _restaurantData.GetAll();
            model.CurrentMessage = "";
            return View(model); 
            
        }
    }
}
