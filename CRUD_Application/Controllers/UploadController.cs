﻿using CRUD_Application.Data;
using CRUD_Application.Models.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Data;


namespace CRUD_Application.Controllers
{
    public class UploadController : Controller
    {
        private readonly ApplicationContext context;
        private readonly IHostingEnvironment environment;
        public UploadController(ApplicationContext context,IHostingEnvironment environment)
        {
            this.context = context;
            this.environment = environment;

        }
        [HttpGet]
        public IActionResult UploadImage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UploadImage(ImageCreateModel model)
        {
            if (ModelState.IsValid)
            {/*
                var path = environment.WebRootPath;
                var filePath = "Content/Image/"+ model.ImagePath.FileName;
                var fullPath = Path.Combine(path, filePath);
                UploadFile(model.ImagePath, fullPath);
                var data = new Image()
                {
                    Name = model.Name,
                    ImagePath = filePath
                };
                context.Add(data);
                context.SaveChanges();*/
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
            
        }
        public void UploadFile(IFormFile file,string path)
        {
            FileStream stream = new FileStream(path, FileMode.Create);
            file.CopyTo(stream);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
