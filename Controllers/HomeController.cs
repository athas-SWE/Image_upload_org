using Image_upload.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Image_upload.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        imageFileContext db = new imageFileContext();

        public JsonResult Add (Profile model) 
        {
            //Retrive the image 
            var file = Request.Form.Files[0];

            if (file != null && file.Length>0)

            {
                var fileName = Path.GetFileName(file.FileName);
                var filePath= Path.Combine(Directory.GetCurrentDirectory(),);
            }
        }
        public IActionResult Index()
        {
            return View();
        }

       

        
    }
}