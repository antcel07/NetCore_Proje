﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        //generic constructor ekledim
        public AboutManager(IAboutDal aboutDal)
        {
            this._aboutDal = aboutDal;
        }

      

        public void TAdd(About t)
        {
            _aboutDal.Insert(t);
        }

        public void TDelete(About t)
        {
            _aboutDal.Delete(t);
        }

       

        public List<About> TGetList()
        {
           return _aboutDal.GetList();
        }

        public void TUpdate(About t)
        {
             _aboutDal.Update(t);
        }

        public About GetByID(int id)
        {
            return _aboutDal.GetById(id);
           
        }

        public List<About> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }
    }
}
