using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace CheckPay
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Results : Page
    {
        public Results()
        {
            this.InitializeComponent();
        }

     
        public Results(String year, String freq, String gross, String credits)
        {
            
            this.InitializeComponent();
        }

        public object Variables { get; private set; }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            

            base.OnNavigatedTo(e);

            var parameters = (Parameters)e.Parameter;

            tbxBox1.Text = parameters.myGross;

            //determine weather of not its showing
            //enter frame root frame from slides

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

        

        private void Result_BackRequested(object senter, BackRequestedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;

            System.Diagnostics.Debug.WriteLine("Inside Back Requested..");

            if (rootFrame.CanGoBack)
            {
                System.Diagnostics.Debug.WriteLine("Inside if");
                rootFrame.GoBack();

            }//end root frame go back
            else
            {
                System.Diagnostics.Debug.WriteLine("Inside else");
                rootFrame.GoBack();
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }
           
    }
}
