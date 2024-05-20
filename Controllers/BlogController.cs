using KarmaT.Models;
using KarmaT.Models.Blog;
using KarmaT.Models.Home;
using KarmaT.Models.Shop;
using KarmaT.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace KarmaT.Controllers
{
	public class BlogController : Controller
	{
        private readonly DataContext _datacontext;
        public BlogController(DataContext dbcontext)
        {
            _datacontext = dbcontext;
        }
        public IActionResult Index()
		{
            var blogcategoria1 = new List<BlogCategoria>();
            blogcategoria1.Add(new BlogCategoria { Id = 1, Title = "Social Life1", Title1 = "enjoy your sosial life together 1", Path = "cat-post-3.jpg" });
            blogcategoria1.Add(new BlogCategoria { Id = 2, Title = "Politics 1", Path = "cat-post-2.jpg", Title1 = "be a part of politics" });
            blogcategoria1.Add(new BlogCategoria { Id = 3, Title = "Food 1", Path = "cat-post-1.jpg", Title1 = "Let the food be finished" });


            //var blogcategoriaArea = new List<BlogCategoriaArea>( );
            //blogcategoriaArea.Add(new BlogCategoriaArea { Id = 1, Title = "Astronomy Binoculars A Great Alternative 1", Path = "m-blog-1.jpg", About = "MCSE boot camps have its supporters and its detractors. Some people do not understand why you should have to spend money on boot camp when you can get the MCSE study materials yourself at a fraction. 1"});
            //blogcategoriaArea.Add(new BlogCategoriaArea { Id = 2, Title = "The Basic of buying of telescope 2", Path = "m-blog-2.jpg", About= "MCSE boot camps have its supporters and its detractors. Some people do not understand why you should have to spend money on boot camp when you can get the MCSE study materials yourself at a fraction. 2" });
            //blogcategoriaArea.Add(new BlogCategoriaArea { Id = 3, Title = "The Glossary Of Telescopes 3", Path = "m-blog-3.jpg", About = "MCSE boot camps have its supporters and its detractors. Some people do not understand why you should have to spend money on boot camp when you can get the MCSE study materials yourself at a fraction. 3" });
            //blogcategoriaArea.Add(new BlogCategoriaArea { Id = 4, Title = "The Night Sky 4", Path = "m-blog-4.jpg", About = "MCSE boot camps have its supporters and its detractors. Some people do not understand why you should have to spend money on boot camp when you can get the MCSE study materials yourself at a fraction. 4" });
            //blogcategoriaArea.Add(new BlogCategoriaArea { Id = 5, Title = "Telescopes 101 5", Path = "m-blog-5.jpg", About = "MCSE boot camps have its supporters and its detractors. Some people do not understand why you should have to spend money on boot camp when you can get the MCSE study materials yourself at a fraction. 5" });


            var popularpost = new List<PopularPost>();
            popularpost.Add(new PopularPost { Id = 1, Title = "Space The Final Frontier 1", Date = "02 Hours ago", Path = "post1.jpg" });
            popularpost.Add(new PopularPost { Id = 2, Title = "The Amazing Hubble 2", Date = "01 Hours ago", Path = "post2.jpg" });
            popularpost.Add(new PopularPost { Id = 3, Title = "Astronomy Or Astrology 3", Date = "04 Hours ago", Path = "post3.jpg" });
            popularpost.Add(new PopularPost { Id = 3, Title = "Asteroids telescope 4", Date = "03 Hours ago", Path = "post4.jpg" });



            HomeIndexVM homeIndexVM = new HomeIndexVM();
            homeIndexVM.BlogCategorias = blogcategoria1;
            
            homeIndexVM.PopularPosts= popularpost;


            homeIndexVM.BlogCategoriaAreas = _datacontext.BlogCategoriaArea1.ToList();




            return View(homeIndexVM);
		}

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BlogCategoriaArea blogCategoriaArea)
        {
            _datacontext.BlogCategoriaArea1.Add(blogCategoriaArea);
            _datacontext.SaveChanges();
            return RedirectToAction("index");
        }
	}
}
