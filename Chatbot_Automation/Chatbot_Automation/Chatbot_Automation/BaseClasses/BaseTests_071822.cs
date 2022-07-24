using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System.IO;
using Selenium_NUnit_ChatbotTest.Ultilities;
//using Selenium_NUnit_ChatbotTest.Test;
using Selenium_NUnit_ChatbotTest.BaseClasses;

namespace Selenium_NUnit_ChatbotTest.BaseClasses
{
    //public class BaseTests
    public class BaseTests_071822 : BasePage_071822    // 7/18/22 updated
    {
        //public BaseTests_071822(IWebDriver webDriver) : base(webDriver)    // 7/18/22 added
        //public BaseTests_071822() : base()      // 7/18/22 updated
        //{            
        //}

        //public IWebDriver driver = new ChromeDriver(FileFolderUltilities.GetFolderPath("drivers\\chromedriver_win32"));

        public AventStack.ExtentReports.ExtentReports extent;
        public AventStack.ExtentReports.ExtentTest test = null;

        [OneTimeSetUp]
        public void OpenChatbotAdmin()
        {
            Console.WriteLine("Opening ChatbotAdmin page");
            driver = new ChromeDriver(FileFolderUltilities.GetFolderPath("drivers\\chromedriver_win32")); // 7/18/22 added
        

            //String URL_QA2 = "https://qa2-dev-kysvesggewzmo-chatbotadmin.azurewebsites.net/chat-bot-admin.html#/login";
            //driver.Url = URL_QA2;

            String URL_QA3 = "https://qa3-dev-m3brdg5s4w76i-chatbotadmin.azurewebsites.net/chat-bot-admin.html#/login";
            driver.Url = URL_QA3;

            driver.Manage().Window.Maximize();
        }
         
        [OneTimeSetUp]
        public void ExtentReportStart()
        {
            string filePath = FileFolderUltilities.GetFolderPath("ExecutionReports\\index.html");

            extent = new AventStack.ExtentReports.ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@filePath);
            extent.AttachReporter(htmlReporter);
            extent.AddSystemInfo("Test Name", "Chatbot Automation");
            extent.AddSystemInfo("Tester: ", "Le Nguyen");

            //htmlReporter.config().setReportName("Web Automation Results");
            //htmlReporter.config().setDocumentTitle("Test Results");
        }

        [OneTimeTearDown]  //[TearDown]
        public void ExtentReportClose()
        {
            extent.Flush();
        }

        
        [SetUp]
        public void CreateTest()
        {
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name); //Group (1): IT WORKED
            //test = SetUpClass.extent.CreateTest(TestContext.CurrentContext.Test.Name);
        }

        [SetUp]
        public void EndTest()
        {
            
        }

        [OneTimeTearDown]
        public void CloseBrowser()
        {
            //Console.WriteLine("Closing browser");
            //driver.Close();
            //driver.Quit();
        }

        public void SignInChatbotAdmin(string email, string pass)
        {

            //-----------Step 1) Click Login button  -----------/
            LoginPage pageLogin = new LoginPage(driver);
            pageLogin.ClickLogin();

            //----------- Step 2) Filling Email, Password, then Sign In -----------/
            SignInPage pageSignIn = new SignInPage(driver);
            pageSignIn.SignIn(email, pass);

            //----------Shuold add verification to verify the Home page is displayed.



        }


    }
}
