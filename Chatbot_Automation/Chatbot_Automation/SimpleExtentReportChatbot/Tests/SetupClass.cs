using AventStack.ExtentReports;

using AventStack.ExtentReports.Reporter;

using NUnit.Framework;

using OpenQA.Selenium;
using SimpleExtentReportChatbot.Ultilities;
using System;

using System.Collections.Generic;

using System.IO;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace SeleniumNunitExtentReport.Test

{

    [SetUpFixture]
    class SetUpClass

    {

        public static AventStack.ExtentReports.ExtentReports extent;

      
        [OneTimeSetUp]
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

        [OneTimeTearDown]  //[TearDown]
        public void ExtentReportClose()
        {
            extent.Flush();
        }



    }

}