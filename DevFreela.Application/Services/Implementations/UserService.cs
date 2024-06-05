using DevFreela.Application.InputModels;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Core.Entities;
using DevFreela.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly DevFreelaDbContext _dbContext;
        public UserService(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Create(NewUserInputModel inputModel)
        {
            var user = new User(inputModel.FullName, inputModel.Email, inputModel.BirthDate);

            _dbContext.Users.Add(user);

            return user.Id;
        }

        public UserDetailViewModel GetById(int id)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Id == id);

            var userDetailViewModel = new UserDetailViewModel(
                user.Id,
                user.FullName,
                user.Email,
                user.BirthDate,
                user.Active,
                user.CreatedAt,
                user.Skills,
                user.OwnedProjects,
                user.FreelanceProjects);

            return userDetailViewModel;
        }

        public void Update(UpdateUserViewModel inputModel)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Id == inputModel.Id);

            user.Update(user.FullName, user.Email, user.BirthDate, user.Active);
        }
    }
}
