using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAW_Store.DTOs;
using DAW_Store.Models;
using DAW_Store.Repositories.UserRepository;

namespace DAW_Store.Services.UserService
{
    public class UserService : IUserService
    {
        public IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public RegisterUserDTO GetUserByUserId(Guid Id)
        {
            User user = _userRepository.FindById(Id);
            RegisterUserDTO userDto = new()
            {
                Name = user.Name,
                Email = user.Email
            };

            return userDto;
        }

        public void CreateUser(RegisterUserDTO user)
        {
            var userToCreate = new User
            {
                Name = user.Name,
                Email = user.Email,
                Password = user.Password,
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now
            };

            _userRepository.Create(userToCreate);
            _userRepository.Save();
        }

        public IQueryable<RespondUserDTO> GetAllUsers()
        {
            IQueryable<RespondUserDTO> usersList = _userRepository.GetAllUsers();
            return usersList;
        }

        public IQueryable<RespondUserDTO> GetAllUsersByName(string name)
        {
            IQueryable<RespondUserDTO> usersList = _userRepository.GetAllUsersByName(name);
            return usersList;
        }

        public void DeleteUserById(Guid id)
        {
            User user = _userRepository.FindById(id);
            _userRepository.Delete(user);
            _userRepository.Save();
        }

        public void UpdateUser(RegisterUserDTO newUser, Guid id)
        {
            User user = _userRepository.FindById(id);

            if (newUser.Name != null)
                user.Name = newUser.Name;

            if (newUser.Email != null)
                user.Email = newUser.Email;


            if (newUser.Password != null)
                user.Password = newUser.Password;

            user.DateModified = DateTime.Now;

            _userRepository.Save();
        }
    }
}