using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NetCore_Proje.Areas.Writer.Controllers
{ 
    [Area("Writer")]
    [Authorize]
    public class DefaultController : Controller
    {
        AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnoucementDal());
        
        public IActionResult Index()
        {
            var values = announcementManager.TGetList();
            return View(values);
        }
        
        
        [HttpGet]

        public IActionResult AnnouncementDetails(int id)
        {
            Announcement announcement= announcementManager.GetByID(id);
            return View(announcement);
        }
    }
}
