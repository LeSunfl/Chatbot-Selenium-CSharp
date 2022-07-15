using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace Selenium_NUnit_TestProject1
{

    public class Chatbot_TriaTests
    {
        IWebDriver driver;

        ///  PUBLIC FUNCTIONS
        /// </summary>
        /// <param name="locator"></param>
        public void waitUntilElementIsEnabled(By locator)
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

        public void waitUntilElementIsDisplayed(By locator)
        {

            Func<IWebDriver, bool> searchEelementDisplayed = d =>
            {
                IWebElement e = d.FindElement(locator);
                //Console.WriteLine(e);
                return e.Displayed;
            };
            //wait until the condition is true
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(searchEelementDisplayed);
        }

        public void waitElementEnabledThenClick(By locator)
        {
            waitUntilElementIsEnabled(locator);
            IWebElement e = driver.FindElement(locator);
            e.Click();
        }

        [OneTimeSetUp]//[SetUp]
        public void OpenChatbotAdmin()
        {
            Console.WriteLine("---Starting FirstSeleniumClass---");
            Console.WriteLine("Starting browser");
            driver = new ChromeDriver("C:\\AUTOMATION TESTING\\3rd_Parties\\chromedriver_win32");  //("D:\\3rdparty\\chrome");

            Console.WriteLine("Opening ChatbotAdmin page");
            //driver.Manage().Timeouts().ImplicitWait(TimeSpan.FromSeconds(50));
            String URL_QA2 = "https://qa2-dev-kysvesggewzmo-chatbotadmin.azurewebsites.net/chat-bot-admin.html#/login";
            String URL_QA3 = "https://qa3-dev-m3brdg5s4w76i-chatbotadmin.azurewebsites.net/chat-bot-admin.html#/login";

            //Console.WriteLine("Opening QA2 environment");
            //driver.Url = URL_QA2;
            Console.WriteLine("Open QA3 environment");
            driver.Url = URL_QA3;
        }

        

        [OneTimeTearDown]//[TearDown]
        public void CloseBrowser()
        {
            //Console.WriteLine("Closing browser");
            //driver.Close();
        }


        //[Test,Order(1), Category("Regression Test")]
        //[Test, Category("Regression Test")]
        public void TrialTest_Login()
        {

            //Thread.Sleep(6000);
            By locatorLogin = By.CssSelector("button[class*='MuiButtonBase-root-61']");
            By locatorSignIn = By.CssSelector("button[id='next']");
            By locatorEmail = By.CssSelector("input[id='logonIdentifier']");
            By locatorPassword = By.CssSelector("input[id='password']");
            
            String email = "le.nguyen.us.123@gmail.com";
            String pass = "Chat!235";
            
            //******** Step 1) Open Chatbot Log In page ***********/

            //Wait until Login button is Displayed and Enabled
            waitUntilElementIsEnabled(locatorLogin);
            IWebElement btnLogin = driver.FindElement(locatorLogin);
            btnLogin.Click();
            Console.WriteLine("Clicked Login button.");

            //******** Step 2) Open Chatbot Sign In page, then sign in with valid account ***********/

            //Wait until the Sign In page is loaded fully (Sign In button is Displayed and Enabled)
            waitUntilElementIsEnabled(locatorSignIn);
            IWebElement btnSignIn = driver.FindElement(locatorSignIn);
            Assert.IsNotNull(btnSignIn, "FAIL - Sign In page is NOT displayed.");
            Console.WriteLine("Sign In page is displayed.");

            IWebElement txtEmail = driver.FindElement(locatorEmail);
            var txtPassword = driver.FindElement(locatorPassword);

            Console.WriteLine("Field attributes");
            Console.WriteLine("+ email's name " + txtEmail.GetAttribute("name"));
            Console.WriteLine("+ Sign In button's innerText : " + btnSignIn.GetAttribute("innerText"));

            Console.WriteLine("Inputting user's information and Sign In..");
            txtEmail.SendKeys(email);
            txtPassword.SendKeys(pass);
            btnSignIn.Click();


            //******** Step 3) Verify Sign successfully and Home page is displayed ***********/

            //Wait until the Chatbot Admin Home page is displayed
            Console.WriteLine("Waiting Chatbot Admin page to be displayed..");

            //By locatorPageTitle = By.CssSelector("h4:contains('Home')"); // NOT working
            By locatorPageTitle = By.CssSelector("h4[class*='MuiTypography-root']");
            waitUntilElementIsDisplayed(By.LinkText("Home"));
            waitUntilElementIsDisplayed(locatorPageTitle);
            Console.WriteLine("Page title: " + driver.FindElement(locatorPageTitle).GetAttribute("innertext"));

            By locatorHome = By.CssSelector("a[href='#/Home']");
            var linkHome = driver.FindElement(locatorHome);
            Assert.That(linkHome.Displayed, Is.True,"FAIL - Home link is NOT displayed");
            Console.WriteLine("Home link title: " + linkHome.GetAttribute("innertext"));



            //NEXT: Try to have better report when Assert is Fail and script continue running in that case

        }

        //[Test, Order(2), Category("Regression Test"), Category("Smoke Test")]
        //[Test, Category("Smoke Test")]
        public void TrialTest_OpenManageQuestionsPage()
        {
            
            //By locatorHome = By.CssSelector("a[href='#/Home']");            
            //waitUntilElementIsEnabled(locatorHome);

            //******** Step 1) Go to Manage Questions page ***********
            
            By locatorManageQuestion = By.CssSelector("a[href='#/questions']");
            waitUntilElementIsEnabled(locatorManageQuestion);
            IWebElement linkManageQuestion = driver.FindElement(locatorManageQuestion);
            Console.WriteLine("MQ link: " + linkManageQuestion.GetAttribute("innertext"));
            //Assert.IsTrue(linkManageQuestion.GetAttribute("innertext") == "Manage Questions", "FAIL - Chatbot Admin page is NOT displayed.");

            Console.WriteLine("Opening Manage Questions page..");
            linkManageQuestion.Click();            
            Console.WriteLine("Manage Questions page is displayed.");
            
        }
        
    }
}