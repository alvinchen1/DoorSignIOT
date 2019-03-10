// Copyright (c) Microsoft. All rights reserved.

using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DoorSignIoT
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        DispatcherTimer dispatcherTimer;
        public void DispatcherTimerSetup()
        {
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 60);
            dispatcherTimer.Start();
        }
        public MainPage()
        {
            this.InitializeComponent();
            DispatcherTimerSetup();
	         

        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var address = "https://doorsignwebsite20190224061537.azurewebsites.net/";
            webView.Navigate(new Uri(address));
        }
        void dispatcherTimer_Tick(object sender, object e)
        {
            webView.Refresh();
        }

    }
 
	     
}