using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace FlyingCommandBar.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void BtnSample1_Click(object sender, RoutedEventArgs e)
        {
            frSamples.Navigate(typeof(Views._1_FullBar));
        }

        private void BtnSample2_Click(object sender, RoutedEventArgs e)
        {
            frSamples.Navigate(typeof(Views._2_FullBarAccent));
        }

        private void BtnSample3_Click(object sender, RoutedEventArgs e)
        {
            frSamples.Navigate(typeof(Views._3_PrimaryOnly));
        }

        private void BtnSample4_Click(object sender, RoutedEventArgs e)
        {
            frSamples.Navigate(typeof(Views._4_PrimaryOverflow));
        }

        private void BtnSample5_Click(object sender, RoutedEventArgs e)
        {
            frSamples.Navigate(typeof(Views._5_PrimarySecondary));
        }

        private void BtnSample6_Click(object sender, RoutedEventArgs e)
        {
            frSamples.Navigate(typeof(Views._6_MailSample));
        }

    }
}
