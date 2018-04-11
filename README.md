# MobileAppDev2

This application was developed as part of a 3rd Year Project Mobile Applications Development module.

The application I chose to create was one I think many people would find useful. It Takes in the user’s marital status, gross pay and Tax Credits. When you choose the calculate button, you are redirected to a second page which calculates Your net pay breaking it down into PRSI, tax and USC.

## Application Requirements
• Well-designed UI that is fit for purpose and provides a good user experience. <br />
• Uses local/roaming storage for storing data and/or settings that are necessary for or
enhance this user experience. <br />
• The app must be more than a simple information app. It must have interactivity as part of
the design.  <br />

## Running Application

To run this application, you can look up checkPay in the windows store and download the application for free.

Alternatively, you can clone this git repository. When cloning this project, you should clone it into your preferred location which you navigate to using your command prompt. Then use the command 

**git clone https://github.com/sarahCarroll/MobileAppDev2.git**

When the repository has been cloned to your local machine, you need to open it using visual studio 2017, and launch the application.

## Design Decisions

When Creating my application, I decided to make a two-page application. The information is passed between the two pages (mainpage and results) by a class called parameters which is being defined in the mainpage and passes to the results page on click of the calculate button.

I am storing the gross pay and the net pay in a service hosted on Azure. I am creating a tile, which alternates every half an hour if the information input by the user changes. This is overridden if you rerun the application.

The results page calculates the USC, PRSI and tax depending on the marital status entered and pay brackets. 

## Future Development
I could further develop the app by moving all the calculations to an external file and pass input information to the file and return the required values.

Another advancement I could make to this project is let the user choose month/year/week to calculate the pay and depending on adjust the resulting values.

## References

**https://stackoverflow.com/questions/35304615/pass-some-parameters-between-pages-in-uwp**<br/>
**https://stackoverflow.com/questions/164926/how-do-i-round-a-decimal-value-to-2-decimal-places-for-output-on-a-page**<br/>
**https://channel9.msdn.com/Series/Windows-10-development-for-absolute-beginners/UWP-061-UWP-Weather-Updating-the-Tile-with-Periodic-Notifications**<br/>
**https://www.revenue.ie/en/Home.aspx**<br/>


