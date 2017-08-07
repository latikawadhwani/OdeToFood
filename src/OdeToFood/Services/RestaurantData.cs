using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
    public class InMemoryRestaurantData : IRestaurantData
    {
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant {Id=1, Name="ABC" },
                new Restaurant {Id=2, Name="XYZ" }
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants;
        }
        List<Restaurant> _restaurants;
    }
}
