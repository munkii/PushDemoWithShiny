using System.Threading.Tasks;
using Shiny.Notifications;

namespace PushDemo
{
    public class NotificationDelegate : INotificationDelegate
    {
        public Task OnEntry(NotificationResponse response)
        {
            return Task.Run(() =>
            {
                System.Diagnostics.Debug.WriteLine("Hello OnEntry");
            });
        }

        /// <summary>
        /// OnReceived is fired when the notification arrives at the device.
        /// </summary>
        /// <param name="notification">Shiny Framework wrapped local notification.</param>
        /// <returns>A Task for async support.</returns>
        public Task OnReceived(Notification notification)
        {
            return Task.Run(() =>
            {
                System.Diagnostics.Debug.WriteLine("Hello OnReceived");
            });
        }
    }
}