using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS.Interfaces
{
    public interface IUserService:Orleans.IGrainWithIntegerKey
    {
        Task<string> GetUserNameAsync(int id);
    }
}
