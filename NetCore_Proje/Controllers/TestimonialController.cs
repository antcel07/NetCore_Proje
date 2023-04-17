using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace NetCore_Proje.Controllers
{
    public class TestimonialController : Controller
    {
        TestimonailManager testimonailManager = new TestimonailManager(new EfTestimonialDal());
        public IActionResult Index()
        {
            var values = testimonailManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddTestimonial()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {
            testimonailManager.TAdd(testimonial);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteTestimonial(int id)
        {
            var values = testimonailManager.GetByID(id);
            testimonailManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditTestimonial(int id)
        {
            var values = testimonailManager.GetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditTestimonial(Testimonial testimonail)
        {
   
            testimonailManager.TUpdate(testimonail);
            return RedirectToAction("Index");
        }
    }
}
