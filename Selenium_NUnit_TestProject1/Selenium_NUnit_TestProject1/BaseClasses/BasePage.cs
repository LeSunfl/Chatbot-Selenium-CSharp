using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Selenium_NUnit_ChatbotTest.Ultilities;
using Selenium_NUnit_ChatbotTest.BaseClasses;

namespace Selenium_NUnit_ChatbotTest.Pages
{
    public class BasePage
    {

        private IWebDriver driver;

        public BasePage_LeftPane LeftPane;
        public BasePage_HeaderPane HeaderPane;
        public BasePage_RightPane RightPane;

        public BasePage(IWebDriver webDriver)
        {
            driver = webDriver;
            initLeftPane();
            initRightPane();
        }

        //public BasePage(IWebDriver webDriver) => driver = webDriver;
        //public IWebDriver driver { get; set; }

        private void initLeftPane()
        {
            By byLeftPane = By.CssSelector("div[class='nav-menu-wrapper']");
            WaitFunctions.WaitUntilElementIsDisplayed(driver, byLeftPane);
            IWebElement  leftPane = driver.FindElement(byLeftPane);
            this.LeftPane = new BasePage_LeftPane(leftPane);
         }

        
        private void initRightPane()
        {
            By byRightPane = By.CssSelector("div[id='main-content']");
            WaitFunctions.WaitUntilElementIsDisplayed(driver, byRightPane);
            IWebElement leftPane = driver.FindElement(byRightPane);
            this.RightPane = new BasePage_RightPane(leftPane);
        }

        private void initHeaderPane()
        {
            By byHeaderPane = By.CssSelector("header[class*='MuiPaper-root']");
            WaitFunctions.WaitUntilElementIsDisplayed(driver, byHeaderPane);
            IWebElement leftPane = driver.FindElement(byHeaderPane);
            this.RightPane = new BasePage_RightPane(leftPane);
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
