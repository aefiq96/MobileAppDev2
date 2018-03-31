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

            int gross = Convert.ToInt32(parameters.myGross);
            int credits = Convert.ToInt32(parameters.myCredits);

            //int z = x + y;

            int TaxYear = 0;
            int TaxSBand1 = 1;
            int TaxSRate1 = 2;
            int TaxSBand2 = 3;
            int TaxSRate2 = 4;

            int TaxMBand1 = 5;
            int TaxMRate1 = 6;
            int TaxMBand2 = 7;
            int TaxMRate2 = 8;

            int PRSIRate = 9;

            int USCBand1 = 10;
            int USCRate1 = 11;      // % rate * 100
            int USCBand2 = 12;
            int USCRate2 = 13;
            int USCBand3 = 14;
            int USCRate3 = 15;
            int USCBand4 = 16;
            int USCRate4 = 17;

            // array indices           0     1      2   3   4   5      6   7   8   9  10     11  12    13   14     15   16  17 
            int[] limits = new int[] { 2018, 34550, 20, -1, 40, 43550, 20, -1, 40, 4, 12012, 50, 7360, 200, 50672, 475, -1, 800 };

            // Tax year
            int taxYear = limits[TaxYear];

            // Calculate PRSI
            float prsiRate = (float)limits[PRSIRate];
            float totalPRSI = (gross * prsiRate) / (float)100.0;

            // Calculate Tax
            float lowerTax = 0;
            float higherTax = 0;
            float totalTax = 0;

            int net = gross;

            if (parameters.myStatus == "single")
            {  // single person
                if (net <= limits[TaxSBand1]) {
                    lowerTax = (float)(net * limits[TaxSRate1]) / (float)100.0;
                }
                else {
                    lowerTax= (float)(limits[TaxSBand1] * limits[TaxSRate1]) / (float)100.0;
                }
                if(net <= limits[TaxSBand1])
                {
                    higherTax = (float)0.0;
                }
                else
                {
                    higherTax= (float)((net - limits[TaxSBand1]) * limits[TaxSRate2]) / (float)100.0;
                }
            }//end of single

            else if (parameters.myStatus == "married")
            {  // single person
                if (net <= limits[TaxMBand1])
                {
                    lowerTax = (float)(net * limits[TaxMRate1]) / (float)100.0;
                }
                else
                {
                    lowerTax = (float)(limits[TaxMBand1] * limits[TaxMRate1]) / (float)100.0;
                }
                if (net <= limits[TaxMBand1])
                {
                    higherTax = (float)0.0;
                }
                else
                {
                    higherTax = (float)((net - limits[TaxMBand1]) * limits[TaxMRate2]) / (float)100.0;
                }
            }//end of single

            totalTax = lowerTax + higherTax - credits; // total tax - Tax Free Allowance


            tbl_gross.Text = gross.ToString("N2");
            tbl_credits.Text = credits.ToString("N2");
            tbl_tax20.Text = lowerTax.ToString("N2");
            tbl_tax40.Text = higherTax.ToString("N2");
            tbl_totalTax.Text = totalTax.ToString("N2");
            tbl_prsi4.Text = totalPRSI.ToString("N2");

          
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
