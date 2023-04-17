﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace NetCore_Proje.ViewComponents.Dashboard
{
    public class ProjectList:ViewComponent
    {
        PortfolioManager pm = new PortfolioManager(new EfPortfolioDal());
        public IViewComponentResult Invoke()
        {
            var values = pm.TGetList();
            return View(values);
        }
    }
}
