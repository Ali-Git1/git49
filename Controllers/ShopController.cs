using KarmaT.Models.Home;
using KarmaT.Models.Shop;
using KarmaT.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace KarmaT.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            var singleProduct = new List<SingleProduct>();
            singleProduct.Add(new SingleProduct { Id = 1, Title = "Addidas new hamer solo", Path = "p1.jpg", Price = "$110", Price1 = "$90" });
            singleProduct.Add(new SingleProduct { Id = 2, Title = "Addidas new hamer sports yellow", Path = "p2.jpg", Price = "$140", Price1 = "$104" });
            singleProduct.Add(new SingleProduct { Id = 3, Title = "Addidas new hamer sport red", Path = "p3.jpg", Price = "$110", Price1 = "$100" });
            singleProduct.Add(new SingleProduct { Id = 4, Title = "Addidas new hamer sport", Path = "p4.jpg", Price = "$100", Price1 = "$55" });
            singleProduct.Add(new SingleProduct { Id = 5, Title = "Addidas new hamer b", Path = "p5.jpg", Price = "$100", Price1 = "$68" });
            singleProduct.Add(new SingleProduct { Id = 6, Title = "Addidas new hamer a", Path = "p6.jpg", Price = "$100", Price1 = "$55" });
            

            HomeIndexVM homeIndexVM = new HomeIndexVM();
            homeIndexVM.singleProducts = singleProduct;

            return View(homeIndexVM);
        }
    }
}
