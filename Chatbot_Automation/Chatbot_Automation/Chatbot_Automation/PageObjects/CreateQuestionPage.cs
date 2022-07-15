using OpenQA.Selenium;
using Selenium_NUnit_ChatbotTest.BaseClasses;
using Selenium_NUnit_ChatbotTest.Ultilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_NUnit_ChatbotTest.PageObjects
{
    public class CreateQuestionPage : BasePage
    {
        private IWebDriver _driver;
        private IWebElement pageContent; //BasePage_RightPane

        By byQuestion = By.CssSelector("textarea[id='question']");
        By byAdd = By.CssSelector("button[class*='MuiButtonBase-root MuiButton-root MuiButton-text button-add button-add-alternatePhrasings']");

        /*
         Alternate Phrasings group (<ul class="jss163"> ) - includes <li class="jss164"> sections:
            1. Zero-Multi Phrase groups include: 
                + Phrase number:    <div class="jss166">
                + Phrase textbox:   <section class="jss167">  (<div class="ra-input ra-input-alternatePhrasings[0].phrasing>") (number = phrase # -1)
                + Remove button:    <span class="jss168">
            2. Add button: <span class="jss168">
        */

        public CreateQuestionPage(IWebDriver webDriver) : base(webDriver)
        {
            //_driver = webDriver;
            pageContent = RightPane.content;
        }
        public IWebElement Question => pageContent.FindElement(byQuestion);
        public IWebElement AddPhrasingButton => pageContent.FindElement(byAdd);   

        public void enterQuestion(string question)
        {
            WaitFunctions.WaitUntilElementIsDisplayed(driver, byQuestion);
            Question.SendKeys(question.Trim());
        }

        public void AddAlternatevePhrasing(string phrasing)
        {
            //Click Add button
            WaitFunctions.WaitUntilElementIsDisplayed(driver, byAdd);
            AddPhrasingButton.Click();

            // Enter phrasing
        }


    }
}
