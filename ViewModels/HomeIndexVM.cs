using KarmaT.Models.Blog;
using KarmaT.Models.Home;
using KarmaT.Models.Shop;

namespace KarmaT.ViewModels
{
    public class HomeIndexVM
    {
        public List<LatestProduct> LatestProducts { get; set; }

        public List<SingleProduct> singleProducts { get; set; }

        public List<BlogCategoria> BlogCategorias { get; set; }

        public List<BlogCategoriaArea> BlogCategoriaAreas { get; set; }

        public List<PopularPost> PopularPosts { get; set; }







    }
}
