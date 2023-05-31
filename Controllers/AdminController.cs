using Microsoft.AspNetCore.Mvc;
using TravelTripProje.Models.Siniflar;
namespace TravelTripProje.Controllers
{
	public class AdminController : Controller
	{
		Context c = new Context();
		public IActionResult Index()
		{
			var degerler = c.Blogs.ToList();
			return View(degerler);
		}
		
		[HttpGet]
		public IActionResult YeniBlog()
		{
			return View();
		}
		[HttpPost]
		public IActionResult YeniBlog(Blog p)
		{
			c.Blogs.Add(p);
			c.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult BlogSil(int id)
		{
			var b = c.Blogs.Find(id);
			c.Blogs.Remove(b);
			c.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult BlogGetir(int id)
		{
			var b1 = c.Blogs.Find(id);
			return View("BlogGetir", b1);
		}
		public IActionResult BlogGuncelle(Blog b)
		{
			var blg = c.Blogs.Find(b.ID);
			blg.Aciklama = b.Aciklama;
			blg.Baslik = b.Baslik;
			blg.BlogImage = b.BlogImage;
			blg.Tarih = b.Tarih;
			c.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
