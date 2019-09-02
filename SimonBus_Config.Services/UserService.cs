using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Simon.Models.Configure;
using SimonBus_Config.Repositories;

namespace SimonBus_Config.Services
{
    public class UserService : IUserService
    {
        public IUserRepository UserRepository;
        public UserService(IUserRepository userRepository)
        {
            UserRepository = userRepository;
        }

        public async Task<List<Users>> GetUsers()
        {
            return await UserRepository.GetUsers();
        }
    }
}
