﻿namespace Doppler.BulkSender.Configuration.Alerts
{
    public class ErrorAlertTypeConfiguration : IAlertTypeConfiguration
    {
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
