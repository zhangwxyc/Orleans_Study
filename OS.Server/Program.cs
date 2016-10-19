using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host=new Orleans.Runtime.Host.SiloHost("Default"))
            {
                host.LoadOrleansConfig();
                host.InitializeOrleansSilo();
                host.StartOrleansSilo();
                Console.WriteLine("Starting...");
                Console.Read();
                host.StopOrleansSilo();
            }
        }
    }
}
