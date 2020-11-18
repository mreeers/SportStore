using Microsoft.AspNetCore.Mvc;
using SportStore.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repository;

        public ProductController(IProductRepository repo)
        {
            repo = repository;
        }

        public IActionResult List() => View(repository.Products);
        
    }
}
