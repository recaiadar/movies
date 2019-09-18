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
        private readonly IHostingEnvironment _hostingEnvironment;

        public ImageController(IImageService imageService, IHostingEnvironment hostingEnvironment)
        {
            _imageService = imageService;
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            System.Drawing.Image image = _imageService.DownloadImageFromUrl("https://picsum.photos", 200, 300);

            var imageDirectory = _hostingEnvironment.WebRootPath + "\\images";
            if (!Directory.Exists(imageDirectory))
                Directory.CreateDirectory(imageDirectory);

            var fileName = Path.Combine(imageDirectory, "image.jpg");
            
            image.Save(fileName);
            return View();
        }
    }
}