using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Drawing;

namespace Movies.Services
{
    public class ImageService : IImageService
    {
        public Image DownloadImageFromUrl(string url, int width, int height)
        {
            Image image = null;

            try
            {
                string imageUrl = url + "/" + width.ToString() + "/" + height.ToString();
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(imageUrl);
                webRequest.AllowWriteStreamBuffering = true;
                webRequest.Timeout = 30000;

                WebResponse webResponse = webRequest.GetResponse();

                Stream stream = webResponse.GetResponseStream();

                image = Image.FromStream(stream);

                webResponse.Close();
            }
            catch (Exception)
            {
                return null;
            }

            return image;
        }

    }
}
