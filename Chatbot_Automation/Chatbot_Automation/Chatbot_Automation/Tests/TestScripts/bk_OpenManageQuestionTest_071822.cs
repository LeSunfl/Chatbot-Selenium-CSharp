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

    //[TestFixture]
    //class CreateQuestionTests__ERFail : BaseTests_ERFail
    class bk_OpenManageQuestionTest_071822 : BaseTests_071822
    {
        //public OpenManageQuestionTest_071822(IWebDriver webDriver) : base(webDriver) { }  // 7/18/22 added

        //public OpenManageQuestionTest_071822() : base() { }

        #region TestParamaters
        String email = "le.nguyen@jenzabar.com"; //"le.nguyen.us.123@gmail.com";
        String pass = "Chat!236"; //"Chat!235";
        BasePage Page;
        string NewQuestionName = "LeTestNewQuestion";  //need to make it dynamic: Question<date><time>
        #endregion

        [Author("LeNguyen")]
        [Description("Create Question Test")]
        //[Test]
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
                //Page = new BasePage(driver);              // 7/18/22 updated
                //Page.LeftPane.OpenManageQuestionsPage();  // 7/18/22 updated
                LeftPane.OpenManageQuestionsPage();         // 7/18/22 updated
                Assert.That(Page.RightPane.GetPageTitle(), Is.EqualTo("Manage Questions"));
                test.Log(Status.Info, "Opened ManageQuestions page");
                //Console.WriteLine("Opened Manage Questions page.");

                //**3. Open Create QuestionsPage 
                //ManageQuestionsPage pageManageQ = new ManageQuestionsPage(driver);
                ManageQuestionsPage_071822 pageManageQ = new ManageQuestionsPage_071822();
                pageManageQ.OpenCreateQuestionPage();

                /*
                try
                {
                    Assert.That(Page.RightPane.GetPageTitle(), Is.EqualTo("Create a New Question"));
                }
                catch (Exception ex) //Note: if this verification is failed, the script still continue executing
                {
                    test.Fail("Page title is not correct. Expected: 'Create a New Question' - Actual : " + Page.RightPane.GetPageTitle());
                }
                
                test.Log(Status.Pass, "Opened Create Question page successfully");
                //Console.WriteLine("Opened Create Question page successfully");

                //** 4. Enter data in the Create Question page
                CreateQuestionPage pageNewQ = new CreateQuestionPage(driver);
                pageNewQ.enterQuestion(NewQuestionName);
                pageNewQ.AddPhrasingButton.Click();
                //pageNewQ.AddAlternatevePhrasing("Phrase Test 01");

                */
            }
            catch (Exception ex)
            {   //Console.WriteLine(ex.Message);
                test.Log(Status.Fail, ex.ToString());
                //report.LogStatusFAIL(ex.ToString());
                throw;
            }

            //Console.WriteLine("Searching questions in Manage Questions page");
            //pageManageQ.SearchQuestions("library");

        }



    }
}
