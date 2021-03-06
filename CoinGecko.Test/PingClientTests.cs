using System.Threading.Tasks;
using CoinGecko.Clients;
using Xunit;

namespace CoinGecko.Test
{
    public class PingClientTests
    {
        private readonly CoinGeckoClient _client;
        public PingClientTests()
        {
            _client = CoinGeckoClient.Instance;
        }
        [Fact]
        public async Task Ping_Method_Must_Return_ToTheMoon()
        {
            var result = await _client.PingClient.GetPingAsync();
            Assert.Equal("(V3) To the Moon!",result.GeckoSays);
        }
        
    }
}