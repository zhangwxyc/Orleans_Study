using System.Threading.Tasks;
using Orleans;

namespace OS.Interfaces
{
    /// <summary>
    /// Grain interface IOrderService
    /// </summary>
	public interface IOrderService : IGrainWithGuidKey
    {
        string Add();
    }
}
