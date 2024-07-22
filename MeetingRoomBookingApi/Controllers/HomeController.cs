using Microsoft.AspNetCore.Mvc;
using MeetingRoomBookingApi.Data;
using MeetingRoomBookingApi.Handlers;

namespace MeetingRoomBookingApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogService _logService;

        public HomeController(ILogService logService)
        {
            _logService = logService;
        }

        public IActionResult Index()
        {
            var logs = _logService.GetLogs();
            return View(logs);
        }
    }
}
