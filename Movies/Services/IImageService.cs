using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Services
{
    public interface IImageService
    {
        Image DownloadImageFromUrl(string url, int width, int height);
    }
}
