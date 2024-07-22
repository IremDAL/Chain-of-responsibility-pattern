namespace MeetingRoomBookingApi.Models
{
    public class MeetingRoom
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int Capacity { get; set; }
        public string RoomName { get; set; }
    }
}
