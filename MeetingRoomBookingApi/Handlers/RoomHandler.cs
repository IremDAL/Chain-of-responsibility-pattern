using System.Collections.Generic;
using MeetingRoomBookingApi.Models;

namespace MeetingRoomBookingApi.Handlers
{
    public abstract class RoomHandler
    {
        protected RoomHandler NextHandler { get; private set; }

        public void SetNextHandler(RoomHandler nextHandler)
        {
            NextHandler = nextHandler;
        }

        public abstract List<MeetingRoom> Handle(Request request);
    }
}
