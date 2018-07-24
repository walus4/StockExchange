using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using StockExchange.Web.Services.Rate;

namespace StockExchange.Web.Services.WebSocked
{
    internal class TimedHostedService : IHostedService, IDisposable
    {
        //private readonly ILogger _logger;
        private Timer _timer;
        //private readonly IContinuousTradingServices _continuousTradingServices;
        private readonly IServiceScopeFactory _scopeFactory;

        public TimedHostedService(IServiceScopeFactory scopeFactory)
        {
            //_logger = logger;
            _scopeFactory = scopeFactory;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
           // _logger.LogInformation("Timed Background Service is starting." + DateTime.Now);

            _timer = new Timer(DoWork, null, TimeSpan.Zero,
                TimeSpan.FromSeconds(10));

            return Task.CompletedTask;
        }

        private void DoWork(object state)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                var continuousTradingServices = scope.ServiceProvider.GetRequiredService<IContinuousTradingServices>();
                   continuousTradingServices.ContinuousTrading();
            }
            // _logger.LogInformation("Timed Background Service is working." + DateTime.Now);
         }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            //_logger.LogInformation("Timed Background Service is stopping.");

            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}