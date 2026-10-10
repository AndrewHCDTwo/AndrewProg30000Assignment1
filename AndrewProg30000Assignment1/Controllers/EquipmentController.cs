using AndrewProg30000Assignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace AndrewProg30000Assignment1.Controllers
{
    public class EquipmentController : Controller
    {
        [Route("AllEquipment")]
        public IActionResult AllEquipment()
        {
            var equipmentList = Repository.EquipmentList;
            return View("EquipmentList", equipmentList);
        }

        [Route("AvailableEquipment")]
        public IActionResult AvailableEquipment()
        {
            var availableEquipment = Repository.EquipmentList.Where(e => e.IsAvailable).ToList();
            return View("EquipmentList", availableEquipment);
        }
    }
}