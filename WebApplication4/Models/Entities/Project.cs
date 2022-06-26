namespace WebApplication4.Models.Entities
{
    public class Project
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int? Stargazers { get; set; }
        public int? Watchers { get; set; }
    }
}
