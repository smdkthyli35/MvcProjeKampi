﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContentController : Controller
    {
        ContentManager contentManager = new ContentManager(new EfContentDal());
        // GET: Content
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ContentByHeading(int id)
        {
            var contentValue = contentManager.GetListByHeadingId(id);
            return View(contentValue);
        }
    }
}