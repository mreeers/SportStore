using Microsoft.AspNetCore.Mvc;
using SportStore.Models.Interface;
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
            repository = repo;
        }

        public IActionResult List() => View(repository.Products);
        
    }
}
