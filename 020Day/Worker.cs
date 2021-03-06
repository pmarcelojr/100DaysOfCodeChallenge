using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

// Tutorial => https://www.codeproject.com/Articles/5263939/Build-a-Windows-Worker-Service-Using-NET-Core-3-1

namespace _020Day
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IServiceScopeFactory _serviceScopeFactory;
        private IList<string> _folderPaths;
        private IConfiguration _configuration;
        private int _numberOfDaysBeforeDelete;
        private int _runIntervallInHours;

        public Worker(ILogger<Worker> logger, IServiceScopeFactory serviceScopeFactory)
        {
            _logger = logger;
            _serviceScopeFactory = serviceScopeFactory;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

                foreach (var path in _folderPaths)
                {
                    if (!stoppingToken.IsCancellationRequested)
                    {
                        // Get old files
                        var files = Directory.GetFiles(path).Select
                                    (file => new FileInfo(file)).Where
                                    (file => file.LastWriteTime < DateTime.Now.AddDays
                                             (-1* _numberOfDaysBeforeDelete)).ToList();

                        // Delete found files
                        files.ForEach(file => file.Delete());
                    }
                }
                await Task.Delay(1000, stoppingToken);
            }
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _configuration = _serviceScopeFactory.CreateScope().
                             ServiceProvider.GetRequiredService<IConfiguration>();
            _numberOfDaysBeforeDelete = int.Parse(_configuration
                                        ["App.Configurations:NumberOfDaysBeforeDelete"]);
            _runIntervallInHours = int.Parse(_configuration
                                            ["App.Configurations:RunIntervallInHours"]);
            _folderPaths = File.ReadAllLines(_configuration
            ["App.Configurations:ConfigurationFilePath"]).Select(x => x.Trim()).ToList();

            return base.StartAsync(cancellationToken);
        }
    }
}
