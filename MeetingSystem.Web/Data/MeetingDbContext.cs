using MeetingRoom.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace MeetingSystem.Web.Data
{
    public class MeetingDbContext : DbContext
    {
        public MeetingDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
