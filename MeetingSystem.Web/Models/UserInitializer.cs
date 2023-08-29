using MeetingRoom.Web.Models;
using MeetingSystem.Web.Data;

namespace MeetingSystem.Web.Models
{
    public static class UserInitializer
    {
        public static WebApplication Seed(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                using var context = scope.ServiceProvider.GetRequiredService<MeetingDbContext>();
                try
                {
                    context.Database.EnsureCreated();
                    var users = context.Users.FirstOrDefault();
                    if (users == null)
                    {
                        context.Users.AddRange(
                            new User
                            {
                                Name = "Admin",
                                Email = "admin123@gmail.com",
                                Password = "Admin@123",
                                Role = UserRole.ADMIN
                            }
                            );
                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString());
                }
                return app;
            }
        }
    }
}
