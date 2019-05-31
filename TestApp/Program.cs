using System;
using System.Threading.Tasks;
using TestApp.Services;

namespace TestApp
{
    class Program
    {
        private static IPotatoService _potatoService;

        public static async Task Main(string[] args)
        {
            _potatoService = new PotatoService();
            var potatoCount = await _potatoService.GetPotatoCount();
            Console.WriteLine($"There are {potatoCount} potatoes today");
        }
    }
}