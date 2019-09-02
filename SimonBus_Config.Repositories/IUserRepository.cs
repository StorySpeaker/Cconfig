using Abp.Domain.Repositories;
using Simon.Models.Configure;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimonBus_Config.Repositories
{
    public interface IUserRepository : IRepository<Users>
    {
        Task<List<Users>> GetUsers();
    }
}
