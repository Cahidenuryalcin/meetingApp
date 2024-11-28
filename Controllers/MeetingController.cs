using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller{
        // public IActionResult Index(){
        //     return View();
        // }
        public string Index(){
            return "meeting/index";
        }
    } 
}