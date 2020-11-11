using _18110209_DangNguyenHoaiThu_BTTuan06.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;


namespace _18110209_DangNguyenHoaiThu_BTTuan06.Controllers
{
    public class TrangChuController : Controller
    {
        // GET: TrangChu
        public LtWeb_BtTuan06Entities _db = new LtWeb_BtTuan06Entities();
        public ActionResult Index()
        {
            var data = (from s in _db.User_1 select s).ToList();
            ViewBag.users = data;
            return View();
        }
    }
}