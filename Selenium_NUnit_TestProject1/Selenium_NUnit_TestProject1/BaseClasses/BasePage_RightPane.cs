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

    public class BasePage_RightPane
    {
        private IWebElement paneContent;

        public BasePage_RightPane(IWebElement leftPane) {
            paneContent = leftPane;
        }
        
    






    }
}
