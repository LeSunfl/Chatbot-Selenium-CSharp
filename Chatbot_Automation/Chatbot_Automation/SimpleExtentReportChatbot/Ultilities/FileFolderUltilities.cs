using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleExtentReportChatbot.Ultilities
{
    public class FileFolderUltilities
    {
        public static string GetFolderPath(string relativeFolderPath)
        {            
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string sFile = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\" + relativeFolderPath);
            string sFilePath = Path.GetFullPath(sFile);
            return sFilePath;

            //string sFile = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\ExecutionReports");
        }
    }
}
