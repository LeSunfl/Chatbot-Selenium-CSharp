using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using Selenium_NUnit_ChatbotTest.Ultilities;

namespace Selenium_NUnit_ChatbotTest.BaseClasses
{

    public class BasePage_LeftPane
    {
        private IWebElement paneContent;
        private IWebDriver driver;

        By byManageQuestion = By.CssSelector("a[href='#/questions']");

        public BasePage_LeftPane(IWebDriver webDriver, IWebElement leftPane)
        {
            paneContent = leftPane;
            driver = webDriver;
        }

        /* List of navigation link menu in the Left Pane */
        public IWebElement linkManageQuestions => paneContent.FindElement(byManageQuestion);

        //public void OpenManageQuestionsPage(IWebDriver driver)
        public void OpenManageQuestionsPage()
        {
            //WaitFunctions.WaitUntilElementIsEnabled(content, byManageQuestion);
            linkManageQuestions.Click();

        }

    }
}
