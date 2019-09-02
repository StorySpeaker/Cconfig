using Simon.Models.Configure;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimonBus_Config.Services
{
    public interface IUserService
    {
        Task<List<Users>> GetUsers();
    }
}
