using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieProject.Models;
using MovieProject.Models.Framework;

namespace MovieProject.Areas.Admin.Controllers
{
    public class CinemaGroupController : Controller
    {
        // GET: Admin/CinemaGroup
        public ActionResult Index()
        {
            var model = new CinemaGroupModel().GetList();
            return View(model);
        }

        // GET: Admin/CinemaGroup/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/CinemaGroup/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/CinemaGroup/Create
        [HttpPost]
        public ActionResult Create(Cinema_Group collection)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    var res = new CinemaGroupModel().Create(collection.Group_Name);
                    if (res > 0 )
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Thêm mới không thành công.");
                        return View();
                    }
                    
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/CinemaGroup/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/CinemaGroup/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/CinemaGroup/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/CinemaGroup/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
