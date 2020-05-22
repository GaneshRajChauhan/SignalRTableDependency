using RealTimeCharts_Server.Models;
using System.Collections.Generic;

namespace RealTimeCharts_Server.Repository
{
    public interface IGaugeRepository
    {
        Gauge Gauge { get; }
        List<ChartModel> GaugeList { get; }
    }
}
