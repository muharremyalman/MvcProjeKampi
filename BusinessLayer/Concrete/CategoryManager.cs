﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {

        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categorydal)
        {
            _categoryDal = categorydal;
        }

        public void CategoryAdd(Category category)
        {
            _categoryDal.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.update(category);
        }

        public Category GetByID(int id)
        {
            return _categoryDal.Get(x=>x.CategoryId==id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }



        //public void CategoryAddBL(Category p)
        //{
        //    if (p.CategoryName == "" || p.CategoryStatus == false ||
        //        p.CategoryName.Length <= 2)
        //    {
        //        //hata
        //    }
        //    else
        //    {
        //        _categorydal.Insert(p);
        //    }
        //}
    }
}
