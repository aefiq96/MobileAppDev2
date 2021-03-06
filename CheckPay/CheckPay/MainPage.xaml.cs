﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Core;
using Windows.UI.Notifications;
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
       // ObservableCollection<FontFamily> taxYears = new ObservableCollection<FontFamily>();
       // List<string> lstVal = new List<string> { "Month", "Week", "Year"};

        private string selected;

        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            base.OnNavigatedTo(e);

            Frame rootFrame = Window.Current.Content as Frame;
            //if you can go back , show the back button in the top left
            if (rootFrame.CanGoBack)
            {
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility =
                    AppViewBackButtonVisibility.Visible;
            }
            //else collapse the back button on the homepage
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

        //onclick for the Calculate button
        private void OnClick1(object sender, RoutedEventArgs e)
        {
            //reference parameters class. 
            Parameters par = new Parameters();

            par.myCredits = tbx_credits.Text;
            par.myGross = tbx_Gross.Text;
            par.myStatus = tbx_marraige.Text;
           
            //when clicked the forground colour of the button changed to red
            button1.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
           
            //when button is clicked you go to the results page and the values stored in par are also passed over
            Frame.Navigate(typeof(Results), par);

        }

        private void tbxUserEntered_GotFocusWage(object sender, RoutedEventArgs e)
        {
            //highlight the field when inputting values
            tbxUserEntered.SelectAll();
        }


        private void tbxUserEntered_GotFocus(object sender, RoutedEventArgs e)
        {
            tbx_credits.SelectAll();
        }

        private void tbx_Gross_GotFocus(object sender, RoutedEventArgs e)
        {
            tbx_Gross.SelectAll();
        }

        private void tbx_marraige_GotFocus(object sender, RoutedEventArgs e)
        {
            tbx_marraige.SelectAll();
        }

        private void cb_TaxYear_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox combo = sender as ComboBox;

            selected = combo.SelectedItem.ToString();

            System.Diagnostics.Debug.WriteLine(selected);
        }

      

        
    }
}
