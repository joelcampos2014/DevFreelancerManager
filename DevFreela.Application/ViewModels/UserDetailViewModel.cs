using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
    public class UserDetailViewModel
    {
        public UserDetailViewModel(
            int id, 
            string fullName,
            string email,
            DateTime birthDate, 
            bool active, 
            DateTime createdAt, 
            List<UserSkill>? userSkills, 
            List<Project>? ownedProjects, 
            List<Project>? freelanceProjects)
        {
            Id = id;
            FullName = fullName;
            Email = email;
            BirthDate = birthDate;
            Active = active;
            CreatedAt = createdAt;
            UserSkills = userSkills;
            OwnedProjects = ownedProjects;
            FreelanceProjects = freelanceProjects;
        }

        public int Id { get; private set; }
        public string FullName { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public bool Active { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public List<UserSkill>? UserSkills { get; private set; }
        public List<Project>? OwnedProjects { get; private set; }
        public List<Project>? FreelanceProjects { get; private set; }
    }
}
