using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    [Route("[controller]/[action]")]
    public class AboutController
    {
        
        public string Phone()
        {
            return "1+445-55-6666";
        }

        
        public string Address()
        {
            return "USA";
        }
    }
}
