using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace NetCore_Proje.ViewComponents.Testimonial
{
    public class TestimonialList:ViewComponent
    {
        TestimonailManager testimonailManager = new TestimonailManager(new EfTestimonialDal());

        public IViewComponentResult Invoke()
        {
            var values = testimonailManager.TGetList();
            return View(values);
        }
    }
}
