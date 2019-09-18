using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Movies.Models;
using Movies.Services;

namespace Movies.Controllers
{
    public class ImageController : Controller
    {
        private readonly IImageService _imageService;

        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }

        public IActionResult Index()
        {
            System.Drawing.Image image = _imageService.DownloadImageFromUrl("https://picsum.photos", 200, 300);
            
            var imagePath = AppDomain.CurrentDomain.BaseDirectory + "\\images";
            if (!Directory.Exists(imagePath))
                Directory.CreateDirectory(imagePath);
            string fileName = Path.Combine(imagePath, "image.jpg");
            image.Save(fileName);
            return View();
        }
    }
}