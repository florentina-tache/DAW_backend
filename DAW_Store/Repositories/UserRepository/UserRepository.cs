using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAW_Store.Data;
using DAW_Store.DTOs;
using DAW_Store.Models;
using DAW_Store.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DAW_Store.Repositories.UserRepository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly DAW_Store_context _context;

        public UserRepository(DAW_Store_context context) : base(context)
        {
            _context = context;
        }

        public IQueryable<RespondUserDTO> GetAllUsers()
        {
            return _table.Select(x => new RespondUserDTO
            {
                Name = x.Name,
                Email = x.Email,
            });
        }

        public IQueryable<RespondUserDTO> GetAllUsersByName(string name)
        {
            return _table.Where(x => x.Name.Equals(name))
                        .Select(x => new RespondUserDTO
                        {
                            Name = x.Name,
                            Email = x.Email,
                        });
        }
    }
}