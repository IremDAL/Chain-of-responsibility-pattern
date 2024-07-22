using Microsoft.EntityFrameworkCore;
using MeetingRoomBookingApi.Models;

namespace MeetingRoomBookingApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<MeetingRoom> MeetingRoom { get; set; }
        public DbSet<Request> Requests { get; set; }
    }
}
