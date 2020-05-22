using RealTimeCharts_Server.EF;
using RealTimeCharts_Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RealTimeCharts_Server.Repository
{
    public class GaugeRepository : IGaugeRepository
    {
        private readonly Func<GaugeContext> _contextFactory;

        public Gauge Gauge => GetGauge();
        public List<ChartModel> GaugeList=>GetGaugeList();

        public GaugeRepository(Func<GaugeContext> context)
        {
            _contextFactory = context;
        }

        private Gauge GetGauge()
        {
            using (var context = _contextFactory.Invoke())
            {
                return context.Gauges.FirstOrDefault();
            }
        }
        private List<ChartModel> GetGaugeList()
        {
            using (var context = _contextFactory.Invoke())
            {
                var gauge= context.Gauges.FirstOrDefault();
                var r = new Random();
                return new List<ChartModel>()
            {
                new ChartModel { Data = new List<int> { gauge.Cpu }, Label = "Data1" },
                new ChartModel { Data = new List<int> { gauge.Memory }, Label = "Data2" },
                new ChartModel { Data = new List<int> { gauge.Network }, Label = "Data3" },
                new ChartModel { Data = new List<int> { gauge.Id }, Label = "Data4" }
            };
            }
        }
    }
}
