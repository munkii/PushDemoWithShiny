using Microsoft.Extensions.DependencyInjection;
using Shiny;
using Shiny.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace PushDemo
{
    public class DemoStartup : Shiny.ShinyStartup
    {
        public override void ConfigureServices(IServiceCollection services, IPlatform platform)
        {
            ////services.UseNotifications<NotificationDelegate>(null);
        }
    }
}
