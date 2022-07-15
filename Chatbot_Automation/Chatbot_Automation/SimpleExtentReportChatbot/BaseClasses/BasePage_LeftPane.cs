using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using SimpleExtentReportChatbot.Ultilities;

namespace SimpleExtentReportChatbot.BaseClasses
{

    public class BasePage_LeftPane
    {
        private IWebElement paneContent;

        By byManageQuestion = By.CssSelector("a[href='#/questions']");

        public BasePage_LeftPane(IWebElement leftPane) {
            paneContent = leftPane;
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
