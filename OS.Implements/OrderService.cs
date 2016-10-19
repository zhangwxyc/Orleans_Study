using System;
using System.Threading.Tasks;
using Orleans;
using OS.Interfaces;

namespace OS.Implements
{
    /// <summary>
    /// Grain implementation class OrderService.
    /// </summary>
    public class OrderService : Grain, IOrderService
    {
        public string Add()
        {
            return "Test";
        }
    }
}
