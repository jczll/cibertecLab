using Chinook.DataAccess.Interfaces;
using Chinook.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.DataAccess.Repository
{
    public class UsersRepository : GenericRepository<Users>, IUsersRepository
    {
        public UsersRepository(DbContext pContext) : base(pContext)
        {

        }

        public Users GetUserByLogin(string login, string password)
        {
            return this.context.Set<Users>()
                .Where(item => item.Login == login && item.Password == password)
                .FirstOrDefault();
        }
    }
}
