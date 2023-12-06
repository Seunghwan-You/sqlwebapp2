using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sqlwebapp2.Models;
using sqlwebapp2.Services;

namespace sqlwebapp2.Pages
{
    public class IndexModel : PageModel
    {

        public List<Product> Products;
        private readonly IProductService _productService;
        public IndexModel(IProductService productService)
        {
            _productService = productService;
        }

        public void OnGet()
        {
          Products = _productService.GetProducts();
        }

        }     
    }

