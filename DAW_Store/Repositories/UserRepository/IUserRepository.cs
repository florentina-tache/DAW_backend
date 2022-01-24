using System;
using System.Collections.Generic;
using System.Linq;
using DAW_Store.DTOs;
using DAW_Store.Models;
using DAW_Store.Repositories.GenericRepository;

namespace DAW_Store.Repositories.UserRepository
{
    public interface IUserRepository : IGenericRepository<User>
    {
        IQueryable<RespondUserDTO> GetAllUsers();
        IQueryable<RespondUserDTO> GetAllUsersByName(string name);

    }
}