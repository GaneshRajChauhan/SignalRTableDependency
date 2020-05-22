using Microsoft.EntityFrameworkCore;
using RealTimeCharts_Server.Models;

namespace RealTimeCharts_Server.EF
{
    public class GaugeContext : DbContext
    {
        public GaugeContext(DbContextOptions<GaugeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Gauge> Gauges { get; set; }
    }
}
