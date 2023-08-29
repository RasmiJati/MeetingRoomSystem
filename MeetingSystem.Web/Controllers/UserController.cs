using MeetingRoom.Web.Models;
using MeetingSystem.Web.Data;
using Microsoft.AspNetCore.Mvc;

namespace MeetingSystem.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly MeetingDbContext _db;

        public UserController(MeetingDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<User> objUserList = _db.Users; 
            return View(objUserList);
        }
    }
}
