using DevFreela.Core.Entities;
using System.Collections.Generic;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>()
            {
                new Project("Meu projeto ASPNET Core", "Minha descrição de Projeto 1", 1, 1, 10000),
                new Project("Meu projeto ASPNET Core", "Minha descrição de Projeto 2", 1, 1, 20000),
                new Project("Meu projeto ASPNET Core", "Minha descrição de Projeto 3", 1, 1, 30000),
            };

            Users = new List<User>()
            {
                new User("Jorel", "joelcampos@gmail.com", new DateTime(1996, 1, 1)),
                new User("Alita", "alita@gmail.com", new DateTime(1996, 1, 1)),
                new User("Seya", "seya@gmail.com", new DateTime(1996, 1, 1))
            };

            Skills = new List<Skill>()
            {
                new Skill(".NET Core"),
                new Skill("C#"),
                new Skill("SQL")
            };
        }
        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
        public List<ProjectComment> ProjectComments { get; set; }
    }
}
