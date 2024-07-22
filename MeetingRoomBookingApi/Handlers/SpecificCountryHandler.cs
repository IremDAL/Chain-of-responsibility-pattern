using System;
using System.Collections.Generic;
using System.Linq;
using MeetingRoomBookingApi.Data;
using MeetingRoomBookingApi.Models;
using Microsoft.Extensions.Logging;

namespace MeetingRoomBookingApi.Handlers
{
    public class SpecificCountryHandler : RoomHandler
    {
        private readonly AppDbContext _context;
        private readonly string _country;
        private readonly ILogService _logService;

        public SpecificCountryHandler(AppDbContext context, string country, ILogService logService)
        {
            _context = context;
            _country = country;
            _logService = logService;
        }

        public override List<MeetingRoom> Handle(Request request)
        {
            _logService.Log($"Handling request for country: {_country}");

            var availableRooms = _context.MeetingRoom
                .Where(room =>
                              room.City.ToLower().Equals(request.City.ToLower())
                             && room.Capacity >= request.Participants
                             && room.Country.ToLower().Equals(_country.ToLower()))
                .ToList();

            if (availableRooms.Any())
            {
                return availableRooms;
            }
            else if (NextHandler != null)
            {
                return NextHandler.Handle(request);
            } else
            {
                return new List<MeetingRoom>(); // Boş liste döner
            }
        }
           
    }
}
