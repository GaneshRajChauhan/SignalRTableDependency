namespace RealTimeCharts_Server.SqlTableDependencies
{
    public interface IDatabaseSubscription
    {
        void Configure(string connectionString);
    }
}
