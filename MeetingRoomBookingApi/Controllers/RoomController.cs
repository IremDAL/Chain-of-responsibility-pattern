using MeetingRoomBookingApi.Data;
using MeetingRoomBookingApi.Handlers;
using MeetingRoomBookingApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

[ApiController]
[Route("api/[controller]")]
public class RoomController : ControllerBase
{
    private readonly RoomHandler _roomHandler;
    private readonly ILogger<RoomController> _logger;
    private readonly ILogService _logService;

    public RoomController(AppDbContext context, ILogger<RoomController> logger, ILogService logService)
    {
        _logger = logger;
        _logService = logService;

        var turkeyHandler = new SpecificCountryHandler(context, "Turkey", logService);
        var usaHandler = new SpecificCountryHandler(context, "USA", logService);
        var germanyHandler = new SpecificCountryHandler(context, "Germany", logService);
        var franceHandler = new SpecificCountryHandler(context, "France", logService);
        //ILogger<RoomController> kullanarak, log mesajlarının hangi sınıftan geldiği açıkça belirtilir. Bu, logların okunmasını ve analiz edilmesini kolaylaştırır.
        // Correctly set the chain of responsibility
        turkeyHandler.SetNextHandler(usaHandler);
        usaHandler.SetNextHandler(germanyHandler);
        germanyHandler.SetNextHandler(franceHandler);

        _roomHandler = turkeyHandler;
    }

    [HttpPost]
    public IActionResult GetAvailableRooms([FromBody] Request request)
    {
        _logger.LogInformation("Received request to get available rooms.");

        var availableRooms = _roomHandler.Handle(request);
        var logs = _logService.GetLogs();

        return Ok(new
        {
            availableRooms,
            logs
        });
    }
}
