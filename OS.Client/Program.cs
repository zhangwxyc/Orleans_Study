using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orleans;

namespace OS.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Orleans.GrainClient.Initialize();
            var service = GrainClient.GrainFactory.GetGrain<OS.Interfaces.IUserService>(0);
            Console.WriteLine(service.GetUserNameAsync(123).Result);
        }
    }
}
