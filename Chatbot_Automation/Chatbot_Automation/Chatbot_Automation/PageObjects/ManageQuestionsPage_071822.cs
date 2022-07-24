using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support;
using Selenium_NUnit_ChatbotTest.BaseClasses;
using Selenium_NUnit_ChatbotTest.PageObjects;
using Selenium_NUnit_ChatbotTest.Ultilities;

namespace Selenium_NUnit_ChatbotTest.BaseClasses
{
    public class ManageQuestionsPage_071822 : BasePage_071822 //BasePage_RightPane
    {
        //private IWebDriver _driver { get; }
        //private IWebElement _driver;    //071422 Grant changed

        

        By bySearch = By.CssSelector("input[id='search']");  //CORRECT DATA
        //By bySearch = By.CssSelector("input[id='abc']");
        By byCreate = By.CssSelector("a[aria-label='Create']"); //By.LinkText("Create"); //XPath("//h5[text()='Create']");

        //public ManageQuestionsPage_071822(IWebDriver webDriver) : base(webDriver)  //071422 Grant changed
        public ManageQuestionsPage_071822() : base()
        {
            //_driver = webDriver;      //071422 Grant changed
        }
        
        private IWebElement textboxSearch => driver.FindElement(bySearch);
        public IWebElement buttonCreate => driver.FindElement(byCreate);


       

        public void SearchQuestions(String text)
        {
            try
            {
                WaitFunctions.WaitUntilElementIsDisplayed(driver, bySearch);
                textboxSearch.SendKeys(text);
            }
            catch (Exception ex) { };
        }

        public void OpenCreateQuestionPage()
        {
            try
            {
                WaitFunctions.WaitElementEnabledThenClick(driver, byCreate);
            }
            catch (Exception ex) { };
        }




        /*
        By byPageTitle = By.CssSelector("h5[class*='MuiTypography-root pageTitle']");
        private IWebElement lblPageTitle => driver.FindElement(byPageTitle);
        public String GetPageTitle()
        {
            WaitFunctions.WaitUntilElementIsDisplayed(driver, byPageTitle);
            return lblPageTitle.Text.Trim();
        } 
        */


    }
}
