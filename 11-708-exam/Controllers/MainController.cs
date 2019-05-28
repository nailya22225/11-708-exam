using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace _11_708_exam.Controllers
{
    public class MainController : Controller
    {
        private Context db { get; set; }

        public MainController(Context context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            //db.Files.Add(file);
            //db.SaveChangesAsync();

            var files = db.Files.ToList();
            ViewBag.Files = files;

            return View();
        }


        public IActionResult Download()
        {
            return View();
        }

        [HttpPost]
        public async IActionResult Download(NewFile newFile)
        {
            var file = newFile.File;

            file.Path = $"Files/{file.BaseName}";

            using (var fileStream = new FileStream(Directory.GetCurrentDirectory() + "/Files", FileMode.Create))
            {
                await newFile.FileData.First().CopyToAsync(fileStream);
            }

                return View();
        }

        [HttpGet]
        public IActionResult File(int? id)
        {
            if (id == null)
            {
                // ошибка
                return View();
            }

            var file = db.Files
                    .Where(q => q.Id == id)
                    .FirstOrDefault();

                ViewBag.File = file;

            return View();
        }
    }
}