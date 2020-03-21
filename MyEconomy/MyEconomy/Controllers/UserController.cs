using Microsoft.AspNet.Identity.Owin;
using MyEconomy.Models.User;
using MyEconomy.Services;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MyEconomy.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private UserService _userService;

        public UserController()
        {
            _userService = new UserService();
        }

        // GET: User
        public ActionResult Index()
        {
            var allUsers = _userService.GetAllUsers();

            return View(allUsers);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public async Task<ActionResult> Create(CreateUserViewModel userView)
        {
            try
            {
                var userManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();

                await _userService.AddUser(userManager, userView);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
