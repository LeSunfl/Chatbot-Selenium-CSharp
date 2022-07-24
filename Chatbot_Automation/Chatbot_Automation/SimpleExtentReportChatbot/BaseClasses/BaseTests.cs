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
using SimpleExtentReportChatbot.Ultilities;
using SeleniumNunitExtentReport.Test;

namespace SimpleExtentReportChatbot.BaseClasses
{
    public class BaseTests
    {
      
        public IWebDriver driver = new ChromeDriver(FileFolderUltilities.GetFolderPath("drivers\\chromedriver_win32"));

        public AventStack.ExtentReports.ExtentReports extent;
        public AventStack.ExtentReports.ExtentTest test = null;


        [OneTimeSetUp]
        public void OpenChatbotAdmin()
        {
            Console.WriteLine("Opening ChatbotAdmin page");
            driver.Manage().Window.Maximize();

            String URL_QA2 = "https://qa2-dev-kysvesggewzmo-chatbotadmin.azurewebsites.net/chat-bot-admin.html#/login";
            driver.Url = URL_QA2;

            //String URL_QA3 = "https://qa3-dev-m3brdg5s4w76i-chatbotadmin.azurewebsites.net/chat-bot-admin.html#/login";
            //driver.Url = URL_QA3;
        }
        // Group (1)  IT WORKED BUT 
         
        
        [SetUp]
        public void CreateTest()
        {
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name); //Group (1): IT WORKED
            //test = SetUpClass.extent.CreateTest(TestContext.CurrentContext.Test.Name);
        }


        [OneTimeTearDown]
        public void CloseBrowser()
        {
            //Console.WriteLine("Closing browser");
            //driver.Close();
            //driver.Quit();
        }

        /*

        public AventStack.ExtentReports.ExtentReports extent;
        public AventStack.ExtentReports.ExtentTest test = null;

        [SetUp]
        public void ExtentReportStart()
        {
            string filePath = FileFolderUltilities.GetFolderPath("ExecutionReports\\index.html");

            extent = new AventStack.ExtentReports.ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@filePath);
            extent.AttachReporter(htmlReporter);
            extent.AddSystemInfo("Tester: ", "Le Nguyen");

            //htmlReporter.config().setReportName("Web Automation Results");
            //htmlReporter.config().setDocumentTitle("Test Results");
        }

        [TearDown]
        public void ExtentReportClose()
        {
            extent.Flush();
        } 
        */
        /*
        //public AventStack.ExtentReports.ExtentReports extent = null;
        public ExtentReportUtilities? report; //= new ExtentReportUtilities();
        public AventStack.ExtentReports.ExtentTest test;

        [OneTimeSetUp]
        public void ExtentReportStart() 
        {
            //Ultilities.ExtentReportUtilities.InitialReport(extent);
            report = new ExtentReportUtilities();
        }

        
        [SetUp]
        public void CreateTestReport()
        {
            test = report.CreateTestFeature(TestContext.CurrentContext.Test.Name);
        }

        [OneTimeTearDown]
        public void ExtentReportClose()
        {
            //Ultilities.ExtentReportUtilities.CloseReport(extent);
            report.CloseReport();
        }

       */


    }
}
