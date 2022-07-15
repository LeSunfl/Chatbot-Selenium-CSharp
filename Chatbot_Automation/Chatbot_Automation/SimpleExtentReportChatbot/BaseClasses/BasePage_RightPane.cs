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

    public class BasePage_RightPane
    {
        private IWebElement paneContent;

        public BasePage_RightPane(IWebElement leftPane) {
            paneContent = leftPane;
        }
        
    






    }
}
