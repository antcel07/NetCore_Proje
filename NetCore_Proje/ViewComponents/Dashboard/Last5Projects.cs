﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace NetCore_Proje.ViewComponents.Dashboard
{
    public class Last5Projects : ViewComponent
    {
       

        public IViewComponentResult Invoke()
        {
            return View();
        }
    
    }
}