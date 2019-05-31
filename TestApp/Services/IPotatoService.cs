using System.Threading.Tasks;

namespace TestApp.Services
{
    public interface IPotatoService
    {
        Task<int> GetPotatoCount();
    }
}