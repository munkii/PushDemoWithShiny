Repro showing an issue with receiving remote notifications in a Xamarin Forms app once Shiny 2.2 Notifcations (local) has been configured

This is the client sample that is available for download from here, https://docs.microsoft.com/en-us/azure/developer/mobile-apps/notification-hubs-backend-service-xamarin-forms

I have changed the Bundle identifier to be the one that I have registered in our back end Azure App Service. 

Editing the DemoStartup class and removing\adding the line `services.UseNotifications<NotificationDelegate>(null);` will fix it, break it respectively


    public override void ConfigureServices(IServiceCollection services, IPlatform platform)
    {
          services.UseNotifications<NotificationDelegate>(null);
    }
