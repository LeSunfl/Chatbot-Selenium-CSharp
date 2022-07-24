using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using Selenium_NUnit_ChatbotTest.Ultilities;

namespace Selenium_NUnit_ChatbotTest.BaseClasses
{
    public class SignInPage //: BasePage
    {
       
        By locatorSignIn = By.CssSelector("button[id='next']");
        By locatorEmail = By.CssSelector("input[id='email']"); //By.CssSelector("input[id='logonIdentifier']"); //7/24/22: id was changed
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

        public void setEmail(string email)
        {
            if (txtEmail.Enabled)
                txtEmail.SendKeys(email);
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
          
            //txtEmail.SendKeys(email);
            setEmail(email);
            setPassword(password);

            buttonSignIn.Click();

        }
    }
}
