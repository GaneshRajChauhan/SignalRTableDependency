﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace RealTimeCharts_Server
{
    public static class AddDbContextFactoryHelper
    {
        public static void AddDbContextFactory<TDataContext>(this IServiceCollection services, string connectionString) where TDataContext : DbContext
        {
            services.AddSingleton<Func<TDataContext>>((ctx) =>
            {
                var options = new DbContextOptionsBuilder<TDataContext>()
                    .UseSqlServer(connectionString)
                    .Options;

                return () => (TDataContext)Activator.CreateInstance(typeof(TDataContext), options);
            });
        }
    }
}
