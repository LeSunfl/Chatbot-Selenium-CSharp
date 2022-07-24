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
//using Selenium_NUnit_ChatbotTest.Tests.Common;

namespace Selenium_NUnit_ChatbotTest.Tests
{

    /* The setup will be executed before any TestFixture
     */
    [SetUpFixture]
    public class Setup  // 07/22/22 - Changed to Public
    {
        
        public static AventStack.ExtentReports.ExtentReports extent;

        [OneTimeSetUp]
        //public void ExtentReportStart()
        protected void ExtentReportStart()
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

        //[OneTimeSetUp]
        /*
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
        */

       [OneTimeTearDown]
        protected void FinishExtentReport()
        {
                Console.WriteLine("[OneTimeTearDown] - ExtentReportConfig.FinishExtentReport");
                extent.Flush();

        }

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

    }
}
