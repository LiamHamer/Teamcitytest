using System;
using TestApp.Services;
using Xunit;

namespace TestApp.Tests
{
    public class UnitTest1
    {
        private readonly IPotatoService _potatoService;
        
        public UnitTest1()
        {
            _potatoService = new PotatoService();
        }
        
        [Fact]
        public async void Test1()
        {
            var potatoCount = await _potatoService.GetPotatoCount();
            Assert.Equal( 5, potatoCount);
        }
    }
}