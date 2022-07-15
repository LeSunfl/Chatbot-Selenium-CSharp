using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using Selenium_NUnit_ChatbotTest.Pages;
using Selenium_NUnit_ChatbotTest.BaseClass;
using Selenium_NUnit_ChatbotTest.Ultilities;


namespace Selenium_NUnit_ChatbotTest.Tests
{
    [TestFixture]
    class LoginTests: BaseTests
    {

        [Test, Order(1)]
        public void TestLoginChatbotAdmin()
        {
            String email = "le.nguyen.us.123@gmail.com";
            String pass = "Chat!235";

            //-----------Step 1) Click Login button  -----------/
            Console.WriteLine("Starting Login function..");
            LoginPage pageLogin = new LoginPage(driver);
            pageLogin.ClickLogin();


            //----------- Step 2) Filling Email, Password, then Sign In -----------/
            SignInPage pageSignIn = new SignInPage(driver);
            //BasePage pageSignIn = new BasePage(driver);
            pageSignIn.SignIn(email, pass);

            //----------- Step 3) Open Manage Questions page -----------/
            /*
            Console.WriteLine("Opening Manage Questions page..");
            By locatorManageQuestion = By.CssSelector("a[href='#/questions']");
            WaitFunctions.WaitElementEnabledThenClick(driver, locatorManageQuestion);

            //BasePage page = new BasePage(driver);
            //page.OpenManageQuestionsPage();

            ManageQuestionsPage pageMQ = new ManageQuestionsPage(driver);
            pageMQ.GetPageTitle();
            Console.WriteLine("Manage Questions page is displayed.");
            */

        }
        
       [Test, Order(2)]
       //[Test]
        public void OpenManageQuestionsPage()
        {
            /*
            Console.WriteLine("Opening Manage Questions page..");
            By locatorManageQuestion = By.CssSelector("a[href='#/questions']");
            WaitFunctions.WaitElementEnabledThenClick(driver, locatorManageQuestion); */

            BasePage Page = new BasePage(driver);
            Page.LeftPane.OpenManageQuestionsPage();

            ManageQuestionsPage pageMQ = new ManageQuestionsPage(driver);
            //Console.WriteLine("Page title: " + pageMQ.GetPageTitle());
            //Console.WriteLine("Manage Questions page is displayed.");

            Console.WriteLine("Searching questions ");
            pageMQ.SearchQuestions("library");

            Console.WriteLine("Opening Manage Questions page.");
            pageMQ.OpenCreateQuestionPage();

        }
        
    }
}
