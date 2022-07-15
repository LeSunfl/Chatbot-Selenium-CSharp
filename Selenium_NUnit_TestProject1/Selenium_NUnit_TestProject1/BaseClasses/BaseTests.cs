using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_NUnit_ChatbotTest.BaseClass
{
    public class BaseTests
    {
        public IWebDriver driver = new ChromeDriver("C:\\AUTOMATION TESTING\\3rd_Parties\\chromedriver_win32");

        //[SetUp]
        [OneTimeSetUp]
        public void OpenChatbotAdmin()
        {
            Console.WriteLine("Opening ChatbotAdmin page");
            //driver.Url = URL;

            //String URL_QA2 = "https://qa2-dev-kysvesggewzmo-chatbotadmin.azurewebsites.net/chat-bot-admin.html#/login";
            //driver.Url = URL_QA2;

            String URL_QA3 = "https://qa3-dev-m3brdg5s4w76i-chatbotadmin.azurewebsites.net/chat-bot-admin.html#/login";
            driver.Url = URL_QA3;

            driver.Manage().Window.Maximize();
       

        }


        //[TearDown]
        [OneTimeTearDown]
        public void CloseBrowser()
        {
            //Console.WriteLine("Closing browser");
            //driver.Close();
            //driver.Quit();
        }
    }
}
