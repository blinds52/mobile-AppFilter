using System;
using System.Threading.Tasks;

using mobile_AppFilter.Helpers;
using mobile_AppFilter.Services;

using Windows.ApplicationModel.Activation;

namespace mobile_AppFilter.Activation
{
    internal class DefaultLaunchActivationHandler : ActivationHandler<LaunchActivatedEventArgs>
    {
        private readonly Type _navElement;
    
        public DefaultLaunchActivationHandler(Type navElement)
        {
            _navElement = navElement;
        }
    
        protected override async Task HandleInternalAsync(LaunchActivatedEventArgs args)
        {
            // When the navigation stack isn't restored navigate to the first page,
            // configuring the new page by passing required information as a navigation
            // parameter
            NavigationService.Navigate(_navElement, args.Arguments);

            // TODO UWPTemplates: This is a sample on how to show a toast notification.
            // You can use this sample to create toast notifications where needed in your app.
            Singleton<ToastNotificationsService>.Instance.ShowToastNotificationSample();
            await Task.CompletedTask;
        }

        protected override bool CanHandleInternal(LaunchActivatedEventArgs args)
        {
            // None of the ActivationHandlers has handled the app activation
            return NavigationService.Frame.Content == null;
        }
    }
}
