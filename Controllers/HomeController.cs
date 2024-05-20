using KarmaT.Models.Home;
using KarmaT.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace KarmaT.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var latestproduct = new List<LatestProduct>();
            latestproduct.Add(new LatestProduct { Id = 1, Title = "Addidas new hamer solo", Path = "p1.jpg", Price="$110",Price1="$90" });
            latestproduct.Add(new LatestProduct { Id = 2, Title = "Addidas new hamer sports 3", Path = "p2.jpg", Price = "$140", Price1 = "$104" });
            latestproduct.Add(new LatestProduct { Id = 3, Title = "Addidas new hamer sport red 1", Path = "p3.jpg", Price = "$110", Price1 = "$99" });
            latestproduct.Add(new LatestProduct { Id = 4, Title = "Addidas new hamer sport yellow", Path = "p4.jpg", Price = "$100", Price1 = "$74" });
            latestproduct.Add(new LatestProduct { Id = 5, Title = "Addidas new hamer b", Path = "p5.jpg", Price = "$100", Price1 = "$68" });
            latestproduct.Add(new LatestProduct { Id = 6, Title = "Addidas new hamer green", Path = "p6.jpg", Price = "$100", Price1 = "$78" });
            latestproduct.Add(new LatestProduct { Id = 7, Title = "Addidas new hamer s5", Path = "p7.jpg", Price = "$100", Price1 = "$74" });
            latestproduct.Add(new LatestProduct { Id = 8, Title = "Addidas new hamer sport blue F10", Path = "p8.jpg", Price = "$100", Price1 = "$89" });

            HomeIndexVM homeIndexVM = new HomeIndexVM();
            homeIndexVM.LatestProducts = latestproduct;

            return View(homeIndexVM);
        }
    }
}
