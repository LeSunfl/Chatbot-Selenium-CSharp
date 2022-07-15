using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Selenium_NUnit_ChatbotTest.Ultilities;
using Selenium_NUnit_ChatbotTest.BaseClasses;

namespace Selenium_NUnit_ChatbotTest.BaseClasses
{
    public class BasePage
    {

        //private IWebDriver driver;
        protected IWebDriver driver;  //071422 Grant changed

        public BasePage_LeftPane LeftPane;
        public BasePage_HeaderPane HeaderPane;
        //public IWebElement RightPane;
        public BasePage_RightPane RightPane;

        public BasePage(IWebDriver webDriver)
        {
            driver = webDriver;
            initLeftPane();
            initRightPane();
            initRightPane(); //added 7/12/22

        }

        private void initLeftPane()
        {
            By byLeftPane = By.CssSelector("div[class='nav-menu-wrapper']");
            WaitFunctions.WaitUntilElementIsDisplayed(driver, byLeftPane);
            IWebElement  leftPane = driver.FindElement(byLeftPane);
            this.LeftPane = new BasePage_LeftPane(driver, leftPane);
         }

        private void initRightPane()
        {
            By byRightPane = By.CssSelector("div[id='main-content']");
            WaitFunctions.WaitUntilElementIsDisplayed(driver, byRightPane);
            IWebElement rightPane = driver.FindElement(byRightPane);
            this.RightPane = new BasePage_RightPane(driver, rightPane);

        }
        /*
        protected IWebElement getRightPane()
        {
            initRightPane();
            return this.RightPane;
        }*/

        private void initHeaderPane()
        {
            By byHeaderPane = By.CssSelector("header[class*='MuiPaper-root']");
            WaitFunctions.WaitUntilElementIsDisplayed(driver, byHeaderPane);
            IWebElement headerPane = driver.FindElement(byHeaderPane);
            this.HeaderPane = new BasePage_HeaderPane (driver, headerPane);
        }

        /*
        By locatorManageQuestion = By.CssSelector("a[href='#/questions']");
        private IWebElement lnkManageQuestions => driver.FindElement(locatorManageQuestion);
        public void OpenManageQuestionsPage(IWebDriver driver)
        {
            WaitFunctions.WaitElementEnabledThenClick(driver, locatorManageQuestion);
        }
        */




    }
}
