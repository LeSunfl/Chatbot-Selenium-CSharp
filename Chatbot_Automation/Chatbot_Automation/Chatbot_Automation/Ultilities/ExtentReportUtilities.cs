using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using Selenium_NUnit_ChatbotTest.Ultilities;


namespace Selenium_NUnit_ChatbotTest.Ultilities
{
    public class ExtentReportUtilities
    {
        static public AventStack.ExtentReports.ExtentReports extent; //{ get; set; }
        //static public AventStack.ExtentReports.ExtentTest test;

        /*/
        public ExtentReportUtilities()
        { 
            InitialReport();
        }*/

        //public void InitialReport(AventStack.ExtentReports.ExtentReports extent)
        //public static void InitialReport(AventStack.ExtentReports.ExtentReports extent)
        public static AventStack.ExtentReports.ExtentReports InitialReport()
        {

            string filePath = FileFolderUltilities.GetFolderPath("ExecutionReports\\index.html");
            //string filePath = "C:\\AUTOMATION TESTING\\Chatbot_Selenium_C#\\Chatbot_Automation\\Chatbot_Automation\\Chatbot_Automation\\ExecutionReports\\index.html";
            //string filePath = "..Chatbot_Automation\\ExtentReports\\index.html"; //"\\Chatbot_Automation\\ExtentReports\\index.html";

            extent = new AventStack.ExtentReports.ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@filePath);
            extent.AttachReporter(htmlReporter);
            extent.AddSystemInfo("Tester: ", "Le Nguyen");

            //htmlReporter.config().setReportName("Web Automation Results");
            //htmlReporter.config().setDocumentTitle("Test Results");

            return extent;
        }

        public static void CloseReport(AventStack.ExtentReports.ExtentReports extent)
        {
            
            extent.Flush(); //it's to close connection and generate extent report

        }

        /*
        public void CreateTestFeature(string Name)
        {
            //extent.CreateTest("Test 01").Info("Test Started");
            //test = this.extent.CreateTest<Scenario>("Login with Q&A Admin role");
            test = extent.CreateTest<Scenario>(Name);
        }*/

        //AventStack.ExtentReports.ExtentTest 
        public static ExtentTest CreateTestFeature(AventStack.ExtentReports.ExtentReports extent, string Name)
        {
            //extent.CreateTest("Test 01").Info("Test Started");
            //test = this.extent.CreateTest<Scenario>("Login with Q&A Admin role");
            return extent.CreateTest<Scenario>(Name);
        }
        /*
        public void LogStatusInfo(string comment)
        {
            test.Log(Status.Info, comment);
            //Console.WriteLine("Log Infor: " + comment);
        }

        public void LogStatusPASS(string comment)
        {
            test.Log(Status.Pass, comment);
        }
        public void LogStatusFAIL(string comment)
        {
            test.Log(Status.Fail, comment);
        }
        */
    }


}
