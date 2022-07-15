using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using Selenium_NUnit_ChatbotTest.BaseClasses;
using Selenium_NUnit_ChatbotTest.Ultilities;

namespace Selenium_NUnit_ChatbotTest.BaseClasses
{

    public class BasePage_RightPane //: BasePage
    {
        private IWebElement paneContent;
        private IWebDriver driver;

        //public BasePage_RightPane(IWebDriver webDriver) : base(webDriver) //changed 071422
        public BasePage_RightPane(IWebDriver webDriver, IWebElement rightPane)
        {
            paneContent = rightPane;
            driver = webDriver;
        }

        //Note: element of page title in the Home page is different 
        By byPageTitle = By.CssSelector("h5[class*='MuiTypography-root pageTitle']");

        public IWebElement content => paneContent;
        private IWebElement lblPageTitle => paneContent.FindElement(byPageTitle);
        //public IWebElement PageTitle => paneContent.FindElement(byPageTitle);

        public String GetPageTitle()
        {
            WaitFunctions.WaitUntilElementIsDisplayed(driver, byPageTitle);
            return lblPageTitle.Text.Trim();
        }

        
        



    }
}
