using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Selenium_NUnit_ChatbotTest.Ultilities;

namespace Selenium_NUnit_ChatbotTest.Pages
{
    public class LoginPage
    {
        private IWebDriver driver { get; }
        private By locatorLogin = By.CssSelector("button[class*='MuiButtonBase-root-61']");

        public LoginPage(IWebDriver webDriver)
        {
            driver = webDriver;
            
            
        }

        public IWebElement buttonLogin => driver.FindElement(locatorLogin);

       /* Way2
        public IWebElement buttonLogin2()
        {
            return driver.FindElement(locatorLogin);
        } */

        public void ClickLogin()
        {
            //Console.WriteLine("Starting Login function..");
            WaitFunctions.WaitUntilElementIsEnabled(driver, locatorLogin);
            buttonLogin.Click();

        }

    }

}
