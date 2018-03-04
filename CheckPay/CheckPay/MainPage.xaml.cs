using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CheckPay
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ObservableCollection<FontFamily> taxYears = new ObservableCollection<FontFamily>();
        List<string> lstVal = new List<string> { "Month", "Week", "Year"};

        public MainPage()
        {
            this.InitializeComponent();
            taxYears.Add(new FontFamily("2018"));
            taxYears.Add(new FontFamily("2017"));
            taxYears.Add(new FontFamily("2016"));
            period.DataContext = lstVal;
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void period_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void OnClick1(object sender, RoutedEventArgs e)
        {
            button1.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
            this.Frame.Navigate(typeof(Results));
        }

        private void tbxUserEntered_GotFocus(object sender, RoutedEventArgs e)
        {
            tbxUserEnteredCredits.SelectAll();
            tbxUserEntered.SelectAll();
        }
    }
}
