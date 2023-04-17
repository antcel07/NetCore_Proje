using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Linq.Expressions;

namespace NetCore_Proje.Areas.Writer.ViewComponents
{
    public class Notification : ViewComponent
    {

        AnnouncementManager announcement = new AnnouncementManager(new EfAnnoucementDal()); 
        public IViewComponentResult Invoke()
        {
            var values=announcement.TGetList().Take(5).ToList();
            return View(values);
        }
    }
}