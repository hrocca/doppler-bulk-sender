﻿using Doppler.BulkSender.Configuration;
using Doppler.BulkSender.Processors.PreProcess;
using Doppler.BulkSender.Classes;
using Doppler.BulkSender.Processors.PreProcess;

namespace Doppler.BulkSender.Configuration
{
    public class BanortePreProcessorConfiguration : IPreProcessorConfiguration
    {
        public PreProcessor GetPreProcessor(ILogger logger, IAppConfiguration configuration)
        {
            return new BanortePreProcessor(logger, configuration);
        }
    }
}
