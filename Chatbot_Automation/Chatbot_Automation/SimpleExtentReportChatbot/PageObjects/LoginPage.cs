using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SimpleExtentReportChatbot.Ultilities;

namespace SimpleExtentReportChatbot.Pages
{
    public class LoginPage
    {
        private IWebDriver driver { get; }
        private By locatorLogin = By.CssSelector("button[class*='MuiButtonBase-root-61']");
        IWebElement ele;
        public LoginPage(IWebDriver webDriver)
        {
            driver = webDriver;   
        }

        //public IWebElement buttonLogin => driver.FindElement(locatorLogin);
        public IWebElement buttonLogin()
        {
            ele = null;
            try
            {
                ele = driver.FindElement(locatorLogin);
            }
            catch { ele = null; }  //catch (Exception ex)

            return ele;
        }

        /* Way2
         public IWebElement buttonLogin2()
         {
             return driver.FindElement(locatorLogin);
         } */

        public void ClickLogin()
        {
            //Console.WriteLine("Starting Login function..");
            WaitFunctions.WaitUntilElementIsEnabled(driver, locatorLogin);
            this.buttonLogin().Click();
            //buttonLogin.Click();

        }

    }

}
