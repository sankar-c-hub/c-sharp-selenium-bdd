using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;
using OpenQA.Selenium.Edge;
using WebDriverManager.Helpers;

namespace SeleniumBDDProject.Utility
{
    public class WebManager
    {
        private static IWebDriver driver;

        public static IWebDriver GetDriver => driver;


        /// <summary>
        /// Launch browser using values from Configuration.xml
        /// </summary>
        /// 

        private static readonly bool WEBDRIVER_PATH = bool.Parse(FileUtility.GetConfigValue("EnableWebdriverPath").ToLower());
        private static readonly bool ENABLE_INCOGNITO = bool.Parse(FileUtility.GetConfigValue("EnableIncognito"));
        public static readonly bool ENABLE_EACH_SCREENSHOT = bool.Parse(FileUtility.GetConfigValue("EnableEachScreenshot"));

        private static void CreateChromeDriver(string browser)
        {
            bool headless = browser.ToLower().Contains("headless");
            var options = new ChromeOptions();

            // Common arguments
            options.AddArguments("--disable-extensions", "--disable-notifications", "--disable-application-cache",
                                 "--ignore-ssl-errors=yes", "--ignore-certificate-errors", "--allow-insecure-localhost");
            if (ENABLE_INCOGNITO) options.AddArgument("--inprivate");
            if (headless)
            {
                options.AddArgument("--headless=new"); // modern headless
                options.AddArguments("--window-size=1920,1080"); // fixed size for headless
            }

            if (WEBDRIVER_PATH)
            {
                Environment.SetEnvironmentVariable("webdriver.chrome.driver", Constants.ChromeDriverPath);
                driver = new ChromeDriver(Constants.ChromeDriverPath, options);
            }
            else
            {
                new DriverManager().SetUpDriver(new ChromeConfig());
                //new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.Latest);
                driver = new ChromeDriver(options);
            }

            if (!headless) driver.Manage().Window.Maximize();
        }

        private static void CreateEdgeDriver(string browser)
        {
            bool headless = browser.ToLower().Contains("headless");
            var options = new EdgeOptions();

            if (ENABLE_INCOGNITO) options.AddArgument("--inprivate");
            if (headless)
            {
                options.AddArgument("--headless");
                options.AddArguments("--window-size=1920,1080");
            }

            if (WEBDRIVER_PATH)
            {
                Environment.SetEnvironmentVariable("webdriver.edge.driver", Constants.EdgeDriverPath);
                driver = new EdgeDriver(Constants.EdgeDriverPath, options);
            }
            new DriverManager().SetUpDriver(new EdgeConfig(), VersionResolveStrategy.Latest);
            driver = new EdgeDriver(options);
        }

        private static void CreateFirefoxDriver(string browser)
        {
            var options = new FirefoxOptions();
            options.SetPreference("dom.push.enabled", false);
            bool headless = browser.ToLower().Contains("headless");
            if (ENABLE_INCOGNITO) options.AddArgument("-private-window");
            if (headless)
            {
                options.AddArgument("--headless");
                options.AddArguments("--window-size=1920,1080");
            }

            if (WEBDRIVER_PATH)
            {
                Environment.SetEnvironmentVariable("webdriver.gecko.driver", Constants.FirefoxDriverPath);
                driver = new FirefoxDriver(Constants.FirefoxDriverPath, options);
            }
            new DriverManager().SetUpDriver(new FirefoxConfig(), VersionResolveStrategy.Latest);
            driver = new FirefoxDriver(options);
        }
        public static void OpenBrowser()
        {
            // Read config values
            string browserName = FileUtility.GetConfigValue("BrowserType").ToLower();
            int implicitWait = int.Parse(FileUtility.GetConfigValue("ImplicitWait"));

            switch (browserName)
            {
                case "chrome":
                    CreateChromeDriver(browserName);
                    break;

                case "firefox":
                    CreateFirefoxDriver(browserName);
                    break;

                case "edge":
                    CreateEdgeDriver(browserName);
                    break;

                default:
                    throw new ArgumentException($"Browser '{browserName}' is not supported.");
            }

            // Apply Implicit Wait from config
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWait);
        }

        public static void GoToUrl(string url)
        {
            if (driver == null)
                throw new Exception("Driver not initialized. Call OpenBrowser first.");

            driver.Navigate().GoToUrl(url);
        }

        public static void CloseBrowser()
        {
            driver?.Close();
            driver = null;
        }

        public static void QuitBrowser()
        {
            driver?.Quit();
            driver = null;
        }
    }
}
