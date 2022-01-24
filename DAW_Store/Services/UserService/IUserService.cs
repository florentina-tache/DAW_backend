using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAW_Store.DTOs;
using DAW_Store.Models;

namespace DAW_Store.Services.UserService
{
    public interface IUserService
    {
        RegisterUserDTO GetUserByUserId(Guid Id);
        public IQueryable<RespondUserDTO> GetAllUsers();
        public IQueryable<RespondUserDTO> GetAllUsersByName(string name);

        void CreateUser(RegisterUserDTO entity);

        void DeleteUserById(Guid id);
        void UpdateUser(RegisterUserDTO user, Guid id);
    }
}