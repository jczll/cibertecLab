using Chinook.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.DataAccess.Interfaces
{
    public interface IUsersRepository : IGeneryRepository<Users>
    {
        Users GetUserByLogin(string login, string password);
    }
}
