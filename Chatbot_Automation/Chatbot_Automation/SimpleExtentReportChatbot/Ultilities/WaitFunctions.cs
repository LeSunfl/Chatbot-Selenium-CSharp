using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleExtentReportChatbot.Ultilities
{
    public class WaitFunctions
    {
        public static void WaitUntilElementIsEnabled(IWebDriver driver, By locator)
        {


            Func<IWebDriver, bool> searchEelementEnabled = d =>
            {
                IWebElement e = d.FindElement(locator);
                //Console.WriteLine(e);
                return e.Displayed && e.Enabled;
            };
            //wait until the condition is true
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(searchEelementEnabled);
        }

        public static void WaitUntilElementIsDisplayed(IWebDriver driver, By locator)
        {

            Func<IWebDriver, bool> searchElementDisplayed = d =>
            {
                IWebElement e = d.FindElement(locator);
                //Console.WriteLine(e);
                return e.Displayed;
            };
            //wait until the condition is true
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(searchElementDisplayed);
        }

        public static void WaitElementEnabledThenClick(IWebDriver driver, By locator)
        {
            WaitUntilElementIsEnabled(driver, locator);
            IWebElement e = driver.FindElement(locator);
            e.Click();
        }
    }
}
