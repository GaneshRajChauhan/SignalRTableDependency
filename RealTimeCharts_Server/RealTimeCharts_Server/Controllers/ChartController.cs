using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using RealTimeCharts_Server.DataStorage;
using RealTimeCharts_Server.HubConfig;
using RealTimeCharts_Server.Repository;
using RealTimeCharts_Server.TimerFeatures;

namespace RealTimeCharts_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChartController : ControllerBase
    {
        private IHubContext<ChartHub> _hub;
        private  IGaugeRepository _gaugeRepo;

        public ChartController(IHubContext<ChartHub> hub,IGaugeRepository gaugeRepo) 
        { 
            _hub = hub;
            this._gaugeRepo = gaugeRepo;
        }

        public IActionResult Get()
        { 
             _hub.Clients.All.SendAsync("transferchartdata", _gaugeRepo.GaugeList); 
            
            return Ok(new { Message = "Request Completed" }); 
        }
    }
}