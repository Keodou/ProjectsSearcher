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

        //public IQueryable<Project> GetProjects()
        //{
        //    return _context.Projects.OrderBy(x => x.ID);
        //}

        public async Task<IQueryable<Project>> GetProjects(string searchString)
        {
            if (string.IsNullOrEmpty(searchString))
            {
                return await Task.Run(() => _context.Projects.OrderBy(x => x.ID));
            }

            else
            {
                return await Task.Run(() => _context.Projects.Where(s => s.Name.Contains(searchString)));
            }
        }
    }
}
