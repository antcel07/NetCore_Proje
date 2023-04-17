using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace NetCore_Proje.ViewComponents.Dashboard
{
    public class ToDoListPanel : ViewComponent
    {
        ToDoListManager tdl = new ToDoListManager(new EfToDoListDal());
        public IViewComponentResult Invoke()
        {
            var values = tdl.TGetList();
            return View(values);
  
        }
    }
}
