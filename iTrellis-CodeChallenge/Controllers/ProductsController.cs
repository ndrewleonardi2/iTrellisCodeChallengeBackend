using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iTrellis_CodeChallenge.Models;
using Microsoft.AspNetCore.Mvc;

namespace iTrellis_CodeChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            Product product1 = new Product(1, "fugiat exercitation adipisicing", 43, false, 13);
            Product product2 = new Product(2, "mollit cupidatat Lorum", 70, true, 18);
            Product product3 = new Product(3, "non quis sint", 33, false, 15);
            Product product4 = new Product(4, "voluptate cupidatat non", 52, true, 18);
            Product product5 = new Product(5, "anim amet occaecat", 39, true, 19);
            Product product6 = new Product(6, "cillum deserunt elit", 47, false, 20);
            Product product7 = new Product(7, "adipiscing reprehenderit et", 71, false, 15);
            Product product8 = new Product(8, "ex mollit laboris", 80, false, 15);
            return new Product[] {
                product1,
                product2,
                product3,
                product4,
                product5,
                product6,
                product7,
                product8
            };
        }
    }
}
