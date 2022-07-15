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

    public class BasePage_HeaderPane
    {
        private IWebElement paneContent;
        private IWebDriver driver;


        public BasePage_HeaderPane(IWebDriver webDriver, IWebElement headerPane) {
            paneContent = headerPane;
            driver = webDriver;
        }
        
     





    }
}
