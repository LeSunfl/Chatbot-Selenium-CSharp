using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_NUnit_ChatbotTest.Ultilities
{
    public class ScreenshotUtilities
    {
        
        public RemoteWebDriver Driver { get; set; }

        //public BasePage CurrenPage { get; set; }
        public MediaEntityModelProvider CaptureScreenshotAndReturnModel(string Name)
        {
            var screenshot = ((ITakesScreenshot)Driver).GetScreenshot().AsBase64EncodedString;
            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot, Name).Build();
        }

        public void TakesScreenshot(string Name)
        {
            ITakesScreenshot ts = Driver as ITakesScreenshot;
            Screenshot screenshot = ts.GetScreenshot();
            screenshot.SaveAsFile("C:\\AUTOMATION TESTING\\Chatbot_Selenium_C#\\Chatbot_Automation\\ExecutionScreenshots");
            //Console.WriteLine("...");
        }

        public static string CaptureScreenshotAndReturnFilePath(IWebDriver driver, String screenShotName)

        {

            ITakesScreenshot ts = (ITakesScreenshot)driver;

            Screenshot screenshot = ts.GetScreenshot();

            var pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            var actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
            var reportPath = new Uri(actualPath).LocalPath;

            //Create folder unless they do not exist
            Directory.CreateDirectory(reportPath + "Reports\\" + "Screenshots");

            var finalpth = pth.Substring(0, pth.LastIndexOf("bin")) + "Reports\\Screenshots\\" + screenShotName;
            var localpath = new Uri(finalpth).LocalPath;

            screenshot.SaveAsFile(localpath + screenShotName + ".png");

            return localpath;

        }
    }
}
