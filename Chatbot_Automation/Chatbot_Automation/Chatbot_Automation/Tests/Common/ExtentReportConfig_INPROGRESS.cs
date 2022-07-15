using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selenium_NUnit_ChatbotTest.Ultilities;

namespace Selenium_NUnit_ChatbotTest.Tests.Common
{

    //[SetUpFixture]
    class ExtentReportConfig_INPROGRESS
    {
        /*
        public ExtentReportUtilities? extent;// = new ExtentReportUtilities();

        [OneTimeSetUp]
        public void ExtentReportStart()
        {
            extent = new ExtentReportUtilities();
        }



        [OneTimeTearDown]
        protected void FinishExtentReport()

        {
            Console.WriteLine("[OneTimeTearDown] - ExtentReportConfig.FinishExtentReport");
            extent.CloseReport();

        }*/

        
        public static AventStack.ExtentReports.ExtentReports extent;

       // [OneTimeSetUp]
        protected void SetupExtentReport()

        {
            Console.WriteLine("[OneTimeSetUp] - ExtentReportConfig.Setup");

            extent = new AventStack.ExtentReports.ExtentReports();
            var dir = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
            DirectoryInfo di = Directory.CreateDirectory(dir + "\\Test_Execution_Reports");

            var htmlReporter = new ExtentHtmlReporter(dir + "\\Test_Execution_Reports” + “\\Automation_Report”" + ".html");
            extent.AddSystemInfo("Test Name", "Chatbot Automation");
            extent.AddSystemInfo("Tester Name", "Le Nguyen");
            extent.AttachReporter(htmlReporter);
        }

       // [OneTimeTearDown]
        protected void FinishExtentReport()
        {
                Console.WriteLine("[OneTimeTearDown] - ExtentReportConfig.FinishExtentReport");
                extent.Flush();

        }
         
    }
}
