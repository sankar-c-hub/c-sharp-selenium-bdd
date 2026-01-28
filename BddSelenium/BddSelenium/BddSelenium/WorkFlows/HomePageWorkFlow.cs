using OpenQA.Selenium;
using BddSelenium.Common;

namespace BddSelenium.WorkFlows
{
    class HomePageWorkFlow
    {
        IWebDriver browser = null;
        static string basePath = System.AppDomain.CurrentDomain.BaseDirectory;
        public void loginPageaccesstopage()
        {
            BrowserManager.LaunchApplication();
        }
    }
}