using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using Selenium_NUnit_ChatbotTest.Ultilities;
using AventStack.ExtentReports;
using Selenium_NUnit_ChatbotTest.BaseClasses;
using Selenium_NUnit_ChatbotTest.BaseClasses;
using Selenium_NUnit_ChatbotTest.PageObjects;

namespace Selenium_NUnit_ChatbotTest.Tests
{

    [TestFixture]
    //class CreateQuestionTests__ERFail : BaseTests_ERFail
    class CreateQuestionTests_OLD : BaseTests
    {

        #region TestParamaters
        String email = "le.nguyen@jenzabar.com"; //"le.nguyen.us.123@gmail.com";
        String pass = "Chat!236"; //"Chat!235";
        BasePage Page;
        string NewQuestionName = "LeTestNewQuestion";  //need to make it dynamic: Question<date><time>
        #endregion

        [Author("LeNguyen")]
        [Description("Create Question Test")]
        [Test]
        public void CreateQuestionWithStaticAnswer()
        {
            try
            {
                Console.WriteLine("********** Starting CreateQuestionWithStaticAnswer test **********");

                //**1. Sign In to Chatbot Admin page 
                SignInChatbotAdmin(email, pass);
                test.Log(Status.Info, "Signed In ChatbotAdmin");
                Console.WriteLine("Signed In ChatbotAdmin.");

                //**2. Open ManageQuestionsPage 
                Page = new BasePage(driver);
                Page.LeftPane.OpenManageQuestionsPage();
                test.Log(Status.Info, "Opened ManageQuestions page");
                Console.WriteLine("Opened Manage Questions page.");

                ManageQuestionsPage pageManageQ = new ManageQuestionsPage(driver);
                //Assert.That(pageManageQ.GetPageTitle(), Is.EqualTo("Manage Questions"));
                test.Log(Status.Pass, "Opened Mange Question page successfully");
                //Console.WriteLine("Opened Mange Question page successfully");


                Console.WriteLine("Searching questions in Manage Questions page");
                pageManageQ.SearchQuestions("library");

                //**3. Open Create QuestionsPage 
                pageManageQ.OpenCreateQuestionPage();
                CreateQuestionPage pageNewQ = new CreateQuestionPage(driver);
                //Assert.That(pageNewQ.GetPageTitle(), Is.EqualTo("Create a New Question"));
                test.Log(Status.Pass, "Opened Create Question page successfully");
                //Console.WriteLine("Opened Create Question page successfully");

            }
            catch (Exception ex)
            {   //Console.WriteLine(ex.Message);
                test.Log(Status.Fail, ex.ToString());
                //report.LogStatusFAIL(ex.ToString());
                throw;
            }

        }


      
    }
}
