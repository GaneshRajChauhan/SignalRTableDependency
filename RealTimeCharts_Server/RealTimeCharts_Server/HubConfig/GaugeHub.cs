using Microsoft.AspNetCore.SignalR;
using RealTimeCharts_Server.Repository;
using System.Threading.Tasks;

namespace RealTimeCharts_Server.HubConfig
{
    public class GaugeHub : Hub
    {
        private readonly IGaugeRepository _repository;

        public GaugeHub(IGaugeRepository repository)
        {
            _repository = repository;
        }

        public async Task GetGaugesData()
        {
            await Clients.All.SendAsync("GetGaugesData", _repository.Gauge);
        }
    }
}
