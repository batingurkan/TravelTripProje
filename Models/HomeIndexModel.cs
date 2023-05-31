using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Models;

public class HomeIndexModel
{
    public List<Blog> Bloglar { get; set; }
    public List<Blog> AraBloglar { get; set; }
    public List<Blog> ListBlog { get; set; }
    public List<Blog> ResmBlog { get; set; }
    public List<Blog> ResmBlog2 { get; set; }
    public string SayfaninAdi { get; set; }
}
