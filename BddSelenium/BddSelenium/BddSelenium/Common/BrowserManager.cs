using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace BddSelenium.Common
{
    public static class BrowserManager
    {
        private static IWebDriver _driver;

        // 🔹 Getter for WebDriver
        public static IWebDriver Driver
        {
            get
            {
                if (_driver == null)
                {
                    OpenBrowser();
                }
                return _driver;
            }
            set
            {
                _driver = value;
            }
        }

        // 🔹 Browser type getter (from config)
        public static string BrowserType
        {
            get
            {
                return CommonUtil.GetConfigValue("BrowserType");
            }
        }

        // 🔹 Application URL getter
        public static string ApplicationUrl
        {
            get
            {
                return CommonUtil.GetConfigValue("URL");
            }
        }

        // 🔹 Open Browser
        public static void OpenBrowser()
        {
            switch (BrowserType.ToLower())
            {
                case "chrome":
                    Driver = new ChromeDriver();
                    break;

                case "firefox":
                    Driver = new FirefoxDriver();
                    break;

                default:
                    throw new Exception($"Unsupported browser: {BrowserType}");
            }

            Driver.Manage().Window.Maximize();
        }

        // 🔹 Launch Application
        public static void LaunchApplication()
        {
            Driver.Navigate().GoToUrl(ApplicationUrl);
            Hooks.log.Add($"Successfully navigated to application URL: {ApplicationUrl}");
        }

        // 🔹 Close Browser
        public static void CloseBrowser()
        {
            if (Driver != null)
            {
                Driver.Quit();
                Driver = null;
            }
        }
    }
}
