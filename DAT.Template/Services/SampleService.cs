using System;
using Microsoft.Extensions.Logging;

namespace DAT.Template.Services
{
    public class SampleService
    {
        private readonly ILogger _logger;

        public SampleService(ILogger logger)
        {
            _logger = logger;
        }

        public void SampleFunction()
        {
            _logger.LogInformation("Sample function called");
        }
    }
}