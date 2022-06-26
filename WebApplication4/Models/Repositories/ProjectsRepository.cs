using WebApplication4.Models.Entities;

namespace WebApplication4.Models.Repositories
{
    public class ProjectsRepository
    {
        private readonly AppDbContext _context;

        public ProjectsRepository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<Project> GetProjects()
        {
            return _context.Projects.OrderBy(x => x.ID);
        }
    }
}
