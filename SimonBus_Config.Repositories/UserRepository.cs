using Dapper;
using Simon.Dapper;
using Simon.Models.Configure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimonBus_Config.Repositories
{
    public class UserRepository : BaseRepository<Users, int>, IUserRepository
    {
        public UserRepository(IDbMysqlConfiguration configuration) : base(configuration)
        {
        }

        public async Task<List<Users>> GetUsers()
        {
            using (ReadConnection)
            {
                string sql = @"select * from Users;";
                var res = await ReadConnection.QueryAsync<Users>(sql);
                return res.ToList();
            }
        }
    }
}
