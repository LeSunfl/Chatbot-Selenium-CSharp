using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using SimpleExtentReportChatbot.Pages;
using SimpleExtentReportChatbot.Ultilities;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using SimpleExtentReportChatbot.BaseClasses;
using AventStack.ExtentReports.Reporter;

namespace SimpleExtentReportChatbot.Tests 
{
    
    [TestFixture]
    class SimpleExtentReport : BaseTests
    {

        /* WORKED WELL
        
        AventStack.ExtentReports.ExtentReports extent;
        public AventStack.ExtentReports.ExtentTest test = null;

        [OneTimeSetUp] //[SetUp]
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

        [SetUp]
        public void CreateTest()
        {
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
        }

        [OneTimeTearDown]  //[TearDown]
        public void ExtentReportClose()
        {
            extent.Flush();
        } 
        */

        [Test, Order(1)]
        [Author("LeNguyen")] [Description("Login to Chatbot Admin website")]
        public void SignInAdmin_1()
        {
            /* Initial extent report */
            //test = extent.CreateTest(TestContext.CurrentContext.Test.Name);

            String email = "le.nguyen.test1@gmail.com";
            String pass = "Chat!236";

            //Create test report for this Test
            //_report = report;
            //test = _report.CreateTestFeature("Login with Q&A Admin role");

            try
            {
                //-----------Step 1) Click Login button  -----------/
                LoginPage pageLogin = new LoginPage(driver);
                pageLogin.ClickLogin();
                test.Log(Status.Info, "Opened Sign In page");

                //----------- Step 2) Filling Email, Password, then Sign In -----------/
                SignInPage pageSignIn = new SignInPage(driver);
                pageSignIn.SignIn(email, pass);
                //report.LogStatusInfo("Signed in with email, password.");
                //report.LogStatusPASS("Test Login PASS");

                test.Log(Status.Info, "Signed in with email, password.");
                test.Log(Status.Pass, "Test Login PASS");

                //Assert.Pass("Sign In successfully");
                //Assert.Fail("Test Assert.Fail");

                //----------Shuold add verification to verify the Home page is displayed.
            } catch (Exception ex)
            {   //Console.WriteLine(ex.Message);
                test.Log(Status.Fail, ex.ToString());
                //report.LogStatusFAIL(ex.ToString());
                throw;
            }

            //report.CloseReport();

        }
        
       
       [Test, Order(2)]
       //[Test]
        public void OpenCreateQuestionPage_1()
        {
            //test = extent.CreateTest("Test OpenCreateQuestionPage").Info("Get Started");
            try
            {
                BasePage Page = new BasePage(driver);
                Page.LeftPane.OpenManageQuestionsPage();
                test.Log(Status.Info, "Openned ManageQuestionsPage");

                ManageQuestionsPage pageMQ = new ManageQuestionsPage(driver);
               
                pageMQ.SearchQuestions("library");              // WILL FAIL  - since the object is updated 
                test.Log(Status.Info, "Searched question");

                //Console.WriteLine("Opening Manage Questions page.");
                pageMQ.OpenCreateQuestionPage();
                //report.LogStatusInfo("Opened Create Question page");
                //report.LogStatusPASS("OpenCreateQuestionPage is PASS");
                test.Log(Status.Info, "Opened Create Question page");
                test.Log(Status.Pass, "OpenCreateQuestionPage is PASS");
            } catch (Exception ex)
            {
                test.Log(Status.Fail, ex.ToString());
                //report.LogStatusFAIL(ex.ToString());
                throw;
            }

        }
        
    }
}
