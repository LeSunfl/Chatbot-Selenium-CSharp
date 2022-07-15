using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_NUnit_ChatbotTest.Ultilities
{
    public class FileFolderUltilities
    {
        public static string GetFolderPath(string relativeFolderPath)
        {
            try
            {
                string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string sFile = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\" + relativeFolderPath);
                string sFilePath = Path.GetFullPath(sFile);
                return sFilePath;
            } catch (Exception ex)
            { return null;  }
            //string sFile = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\ExecutionReports");
        }
    }
}
