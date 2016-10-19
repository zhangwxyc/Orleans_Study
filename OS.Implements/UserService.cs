using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS.Implements
{
    public class UserService : Orleans.Grain,Interfaces.IUserService
    {
        public Task<string> GetUserNameAsync(int id)
        {
            return Task.FromResult<string>($"hahaha :{id}");
        }
    }
}
