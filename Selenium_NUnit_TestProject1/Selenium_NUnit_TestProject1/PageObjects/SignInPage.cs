using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using Selenium_NUnit_ChatbotTest.Ultilities;

namespace Selenium_NUnit_ChatbotTest.Pages
{
    public class SignInPage //: BasePage
    {
       
        By locatorSignIn = By.CssSelector("button[id='next']");
        By locatorEmail = By.CssSelector("input[id='logonIdentifier']");
        By locatorPassword = By.CssSelector("input[id='password']");

        private IWebDriver driver { get; }
        public SignInPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }
        
 

        public IWebElement buttonSignIn => driver.FindElement(locatorSignIn);
        
        public IWebElement txtEmail => driver.FindElement(locatorEmail);
        public IWebElement txtPassword => driver.FindElement(locatorPassword);

       

        public void setPassword(string password)
        {
            if (txtPassword.Enabled)
               txtPassword.SendKeys(password);
        }
        
        
      
        /*
        public IWebElement buttonLogin2()
        {
            return driver.FindElement(locatorLogin);
        } */

        public void SignIn(string email, string password)
        {
            Console.WriteLine("Waiting Sign In page is displayed..");
            WaitFunctions.WaitUntilElementIsEnabled(driver, locatorSignIn);
    
            Assert.That(buttonSignIn.Displayed, Is.True, "FAIL - Sign In page is NOT displayed.");
            Console.WriteLine("Sign In page is displayed.");

            Console.WriteLine("Inputting user's information and Sign In..");
            txtEmail.SendKeys(email);
            //inputPassword.SendKeys(password);
            setPassword(password);

            buttonSignIn.Click();

            Console.WriteLine("Clicked Sign In button");

        }
    }
}
