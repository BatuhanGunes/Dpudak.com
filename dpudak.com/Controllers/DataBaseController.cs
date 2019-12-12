using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dpudak.com.Controllers
{
    public class DataBaseController : Controller
    {
        public ActionResult LectureNotes()
        {
            return View();
        }
        public ActionResult OurInventory()
        {
            return View();
        }
        public ActionResult WhatIsMountaineering()
        {
            return View();
        }
        public ActionResult DownloadFile()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "css/";
            byte[] fileBytes = System.IO.File.ReadAllBytes(path + "modern-business.css");
            string fileName = "modern-business.css";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }
    }
}