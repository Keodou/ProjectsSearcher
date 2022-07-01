using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models.Repositories;
using WebApplication4.Models.Entities;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProjectsRepository _projectsRepository;

        public HomeController(ProjectsRepository projectsRepository)
        {
            _projectsRepository = projectsRepository;
        }

        public async Task<IActionResult> Index(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;
            var model = _projectsRepository.GetProjects(searchString);
            
            return View(await model);
        }
    }
}
