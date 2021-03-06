﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Notifications;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TileUpdatesSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void OnChangeTile(object sender, RoutedEventArgs e)
        {
            TileUpdater tileUpdater = TileUpdateManager.CreateTileUpdaterForApplication();
            string xml = File.ReadAllText("MyTile.xml");
            XmlDocument content = new XmlDocument();
            content.LoadXml(xml);
            TileNotification notification = new TileNotification(content);
            tileUpdater.Update(notification);
        }

        private void OnToastUpdate(object sender, RoutedEventArgs e)
        {
            ToastNotifier toast = ToastNotificationManager.CreateToastNotifier();
            string xml = File.ReadAllText("toast.xml");
            XmlDocument content = new XmlDocument();
            content.LoadXml(xml);
            ToastNotification notification = new ToastNotification(content);
            toast.Show(notification);
        }
    }
}
