using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class BooksController : Controller
    {
        List<WebApplication2.Models.Book> bookList = new List<WebApplication2.Models.Book>()
{
        new WebApplication2.Models.Book()
    {
        baslik = "MVC Dünyasına Merhaba",
        aciklama = "MVC adına herşey",
        fiyat = 100,
        stokadedi = 100,
        tur = "Web programlama",
        yayintarihi = DateTime.Now
    },
         new WebApplication2.Models.Book()
    {
        baslik = "MVC Dünyasına Merhaba",
        aciklama = "MVC adına herşey",
        fiyat = 100,
        stokadedi = 100,
        tur = "Web programlama",
        yayintarihi = DateTime.Now
    },
          new WebApplication2.Models.Book()
    {
        baslik = "MVC Dünyasına Merhaba",
        aciklama = "MVC adına herşey",
        fiyat = 100,
        stokadedi = 100,
        tur = "Web programlama",
        yayintarihi = DateTime.Now
    }
    };

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult create()
        {
            List<string> tur = new List<string>()
            {
                "Macera","Polisiye","Edebiyat","Tarih"
            };
            SelectList turler = new SelectList(tur);
            ViewData["tur"] = turler;

            return View();
        }
        [HttpPost]
        public ActionResult create(Book book)
        {
           
            return View("Thanks",book);
        }
        public ActionResult Liste()
        {
            ViewBag.urunismi = "Mvc Dünyasına Merhaba";
            ViewBag.adet = 10;
            return View();
        }


        public ActionResult Detay()
        {
            var book = new WebApplication2.Models.Book()
            {
                baslik = "MVC Dünyasına Merhaba",
                aciklama = "MVC adına herşey",
                fiyat = 100,
                stokadedi = 100,
                tur = "Web programlama",
                yayintarihi = DateTime.Now
            };
            ViewData["book"] = book;

            return View(book);
        }
    }
}