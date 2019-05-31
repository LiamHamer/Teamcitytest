using System.Threading.Tasks;

namespace TestApp.Services
{
    public class PotatoService: IPotatoService
    {
        public async Task<int> GetPotatoCount()
        {
            await Task.Delay(1000);
            return 5;
        }
    }
}