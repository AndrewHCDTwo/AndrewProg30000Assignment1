using AndrewProg30000Assignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace AndrewProg30000Assignment1.Controllers
{
    public class RequestController : Controller
    {
        [Route("RequestForm")]
        public IActionResult RequestForm()    // GET: /RequestForm
        {
            return View();
        }

        [HttpPost]                            // POST: /RequestForm
        [Route("RequestForm")]
        public IActionResult RequestForm(BorrowRequest newRequest)
        {
            if (ModelState.IsValid)
            {
                Repository.AddRequest(newRequest);      // save the request
                return RedirectToAction("Confirmation");
            }

            return View(newRequest);                    // redisplay the form with errors
        }

        [Route("Confirmation")]
        public IActionResult Confirmation()   // GET: /Confirmation
        {
            return View();
        }
    }
}