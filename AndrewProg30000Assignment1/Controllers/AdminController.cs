using AndrewProg30000Assignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace AndrewProg30000Assignment1.Controllers;

public class AdminController : Controller
{
    [Route("Requests")]
    public IActionResult Requests()    // GET: /Requests
    {
        var requests = Repository.GetAllRequests();
        return View(requests);         // Views/Admin/Requests.cshtml
    }
}