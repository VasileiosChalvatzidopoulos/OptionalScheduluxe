using OptionalUseCase.Data;
using OptionalUseCase.Models;
using OptionalUseCase.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EditProfileApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }

        // Display Login view
        public IActionResult Login()
        {
            return View();
        }

        // Handle Login
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            // Check the form data
            if (ModelState.IsValid)
            {
                // Search for a user with Username and Password
                var user = await _context.Users
                    .FirstOrDefaultAsync(u => u.UserName == model.Username && u.Password == model.Password);

                // If found set Session variables
                if (user != null)
                {
                    HttpContext.Session.SetString("UserId", user.Id.ToString());
                    HttpContext.Session.SetString("Username", user.UserName);

                    // Redirect to Home
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Username or password is incorrect.");
                }
            }
            // If the form has problem, display the Login view
            return View(model);
        }

        // Display the Register view
        public IActionResult Register()
        {
            return View();
        }

        // Handle the Register form
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            // Check the form data
            if (ModelState.IsValid)
            {
                // Create new user with the given data
                var user = new Users
                {
                    UserName = model.Username,
                    Password = model.Password,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Country = model.Country
                };

                // Add the new user to the DB
                _context.Users.Add(user);
                await _context.SaveChangesAsync();

                return RedirectToAction("Login");
            }
            return View(model);
        }

        // Display the Edit Profile view
        [HttpGet]
        public async Task<IActionResult> EditProfile()
        {
            // Check if the use is logged in
            var userId = HttpContext.Session.GetString("UserId");

            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToAction("Login");
            }

            // Get the user
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == int.Parse(userId));

            if (user == null)
            {
                return RedirectToAction("Login");
            }

            // Get the user data
            var model = new EditProfileViewModel
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Username = user.UserName,
                Email = user.Email,
                Country = user.Country
            };

            return View(model);
        }

        // Handle the Edit Profile form
        [HttpPost]
        public async Task<IActionResult> EditProfile(EditProfileViewModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var userId = HttpContext.Session.GetString("UserId");

            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToAction("Login");
            }

            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == int.Parse(userId));

            if (user == null)
            {
                return RedirectToAction("Login");
            }

            // Update user's profile
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.Email = model.Email;
            user.Country = model.Country;

            // Does not work yet
            if (!string.IsNullOrWhiteSpace(model.Password))
            {
                user.Password = model.Password;
            }

            try
            {
                // Save changes to the DB
                _context.Users.Update(user);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error updating profile: " + ex.Message);
                return View(model);
            }
        }

        // Logout the user
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
