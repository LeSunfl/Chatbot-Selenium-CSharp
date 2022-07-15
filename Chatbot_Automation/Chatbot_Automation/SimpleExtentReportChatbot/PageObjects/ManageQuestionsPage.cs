using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support;
using SimpleExtentReportChatbot.Ultilities;

namespace SimpleExtentReportChatbot.Pages
{
    public class ManageQuestionsPage
    {
        private IWebDriver driver { get; }
        By byPageTitle = By.CssSelector("h5[*class*='pageTitle']");
        By bySearch = By.CssSelector("input[id='search']");  //CORRECT DATA
        //By bySearch = By.CssSelector("input[id='abc']");
        By byCreate = By.CssSelector("a[aria-label='Create']"); //By.LinkText("Create"); //XPath("//h5[text()='Create']");

        public ManageQuestionsPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }
       

        private IWebElement lblPageTitle => driver.FindElement(byPageTitle);
        private IWebElement textboxSearch => driver.FindElement(bySearch);
        public IWebElement buttonCreate => driver.FindElement(byCreate);


        //public String GetPageTitle() => lblPageTitle.Text;

        public String GetPageTitle()
        {
            WaitFunctions.WaitUntilElementIsDisplayed(driver, byPageTitle);
            return lblPageTitle.Text;

            //Console.WriteLine("Text: " + lblPageTitle.Text);
            //Console.WriteLine("innerText: " + lblPageTitle.GetAttribute("innerText"));
            //Console.WriteLine("outerText: " + lblPageTitle.GetAttribute("outerText"));
        }

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
        public IWebElement buttonLogin2()
        {
            return driver.FindElement(locatorLogin);
        } */


    }
}
