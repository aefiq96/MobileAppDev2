using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Core;
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

        public ComboBox myYear { get; private set; }
        public ComboBox myFreq { get; private set; }
        public TextBox myGross { get; private set; }
        public TextBox myCredits { get; private set; }

                


        public MainPage()
        {
            this.InitializeComponent();
            taxYears.Add(new FontFamily("2018"));
            taxYears.Add(new FontFamily("2017"));
            taxYears.Add(new FontFamily("2016"));
            freq.DataContext = lstVal;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            base.OnNavigatedTo(e);

            Frame rootFrame = Window.Current.Content as Frame;
            if (rootFrame.CanGoBack)
            {
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility =
                    AppViewBackButtonVisibility.Visible;
            }
            else
            {
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility =
                    AppViewBackButtonVisibility.Collapsed;
            }
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
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

            Parameters par = new Parameters();

            par.myCredits = TaxCredits.Text;
            par.myGross = tbx_Gross.Text;
          
            //myFreq = this.freq;
            button1.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
           

            Frame.Navigate(typeof(Results), par);

        }

        private void tbxUserEntered_GotFocusWage(object sender, RoutedEventArgs e)
        {
            tbxUserEntered.SelectAll();
        }


        private void tbxUserEntered_GotFocus(object sender, RoutedEventArgs e)
        {
            TaxCredits.SelectAll();
        }
    }
}
