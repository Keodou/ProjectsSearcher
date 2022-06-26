using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models.Repositories;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProjectsRepository _projectsRepository;

        public HomeController(ProjectsRepository projectsRepository)
        {
            _projectsRepository = projectsRepository;
        }

        public IActionResult Index()
        {
            var model = _projectsRepository.GetProjects();
            return View(model);
        }
    }
}
