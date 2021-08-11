using ContosoCraftsWebsite.Models;
using ContosoCraftsWebsite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoCraftsWebsite.Pages
{
    public class IndexModel : PageModel
    {
        /*private*/ public readonly ILogger<IndexModel> _logger;
        public JsonFileProductService ProductService ;
        public IEnumerable<Product> Products { get; private set; }
        public IndexModel(
            ILogger<IndexModel> logger,
            JsonFileProductService productService)
        {
            _logger = logger;
            ProductService = productService;
        }

        public void OnGet()
        {
            Products= ProductService.GetProducts();
        }
    }
}
