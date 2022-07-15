using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support;
using Selenium_NUnit_ChatbotTest.Ultilities;

namespace Selenium_NUnit_ChatbotTest.BaseClasses
{
    public class ManageQuestionsPage_OLD
    {
        private IWebDriver _driver { get; }

        By byPageTitle = By.CssSelector("h5[*class*='pageTitle']");
        By bySearch = By.CssSelector("input[id='search']");  //CORRECT DATA
        //By bySearch = By.CssSelector("input[id='abc']");
        By byCreate = By.CssSelector("a[aria-label='Create']"); //By.LinkText("Create"); //XPath("//h5[text()='Create']");

        public ManageQuestionsPage_OLD(IWebDriver webDriver)
        {
            _driver = webDriver;
        }
       

        private IWebElement lblPageTitle => _driver.FindElement(byPageTitle);
        private IWebElement textboxSearch => _driver.FindElement(bySearch);
        public IWebElement buttonCreate => _driver.FindElement(byCreate);


        //public String GetPageTitle() => lblPageTitle.Text;

        public String GetPageTitle()
        {
            WaitFunctions.WaitUntilElementIsDisplayed(_driver, byPageTitle);
            return lblPageTitle.Text;

            //Console.WriteLine("Text: " + lblPageTitle.Text);
            //Console.WriteLine("innerText: " + lblPageTitle.GetAttribute("innerText"));
            //Console.WriteLine("outerText: " + lblPageTitle.GetAttribute("outerText"));
        }

        public void SearchQuestions(String text)
        {
            try
            {
                WaitFunctions.WaitUntilElementIsDisplayed(_driver, bySearch);
                textboxSearch.SendKeys(text);
            }
            catch (Exception ex) { };
        }

        public void OpenCreateQuestionPage()
        {
            try
            {
                WaitFunctions.WaitElementEnabledThenClick(_driver, byCreate);
            }
            catch (Exception ex) { };
        }




        /*
        public IWebElement buttonLogin2()
        {
            return driver.FindElement(locatorLogin);
        } */


    }
}
