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
using Selenium_NUnit_ChatbotTest.BaseClasses;
using Selenium_NUnit_ChatbotTest.Tests.Common;
using NUnit.Framework.Interfaces;


namespace Selenium_NUnit_ChatbotTest.BaseClasses
{
    public class BaseTests_ERFail
    {

        #region Parameters
        //public ExtentReportUtilities? report; //= new ExtentReportUtilities();
        //public ExtentReportUtilities? extent;
        static public AventStack.ExtentReports.ExtentReports extent;
        public ExtentTest test;
        #endregion

        [OneTimeSetUp]
        public void ExtentReportStart()
        {
            Console.WriteLine("[OneTimeSetUp] - BaseTest.ExtentReportStart");
            //extent = new ExtentReportUtilities();
            extent = ExtentReportUtilities.InitialReport();

            /*

            string filePath = FileFolderUltilities.GetFolderPath("ExecutionReports\\index.html");

            extent = new AventStack.ExtentReports.ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@filePath);
            extent.AttachReporter(htmlReporter);
            extent.AddSystemInfo("Tester: ", "Le Nguyen");

            //htmlReporter.config().setReportName("Web Automation Results");
            //htmlReporter.config().setDocumentTitle("Test Results");
            */
        }
    

        public IWebDriver driver = new ChromeDriver(FileFolderUltilities.GetFolderPath("drivers\\chromedriver_win32"));        

        [OneTimeSetUp]
        protected void OpenChatbotAdmin()
        {
            Console.WriteLine("[OneTimeTearDown] - BaseTest.OpenChatbotAdmin");
            //String URL_QA2 = "https://qa2-dev-kysvesggewzmo-chatbotadmin.azurewebsites.net/chat-bot-admin.html#/login";
            //driver.Url = URL_QA2;

            String URL_QA3 = "https://qa3-dev-m3brdg5s4w76i-chatbotadmin.azurewebsites.net/chat-bot-admin.html#/login";
            driver.Url = URL_QA3;

            driver.Manage().Window.Maximize();
        }

        
        
        [OneTimeTearDown]
        protected void FinishExtentReport()
        {
            Console.WriteLine("[OneTimeTearDown] - ExtentReportConfig.FinishExtentReport");
            ExtentReportUtilities.CloseReport(extent);
            //extent.Flush();

        }


        [SetUp]
        public void InitialTest()
        {
            //Console.WriteLine("[SetUp] - BaseTest.InitialTestReport");
            Console.WriteLine("*********"+ TestContext.CurrentContext.Test.Name  + "*********");

            //test = ExtentReportConfig_INPROGRESS.extent.CreateTest(TestContext.CurrentContext.Test.Name);
            //test = extent.CreateTestFeature(TestContext.CurrentContext.Test.Name);
            test = ExtentReportUtilities.CreateTestFeature(extent, TestContext.CurrentContext.Test.Name);

        }

        
        [OneTimeTearDown]
        public void CloseBrowser()
        {
            Console.WriteLine("[OneTimeTearDown] - BaseTest.CloseBrowser");
            //Console.WriteLine("Closing browser");
            driver.Close();
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
