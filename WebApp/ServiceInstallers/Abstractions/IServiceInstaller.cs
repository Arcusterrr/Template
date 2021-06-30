﻿using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebApp.ServiceInstallers.Abstractions
{
    public interface IServiceInstaller
    {
        void Install(IServiceCollection services, IConfiguration configuration, IHostEnvironment env);
    }
}
