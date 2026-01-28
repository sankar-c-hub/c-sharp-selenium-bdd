using System;
using System.IO;

namespace BddSelenium.Common
{
    public static class Constants
    {
        // 🔹 Root directory of execution
        public static readonly string ROOT_DIR =
           Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)!.Parent!.Parent!.FullName;

        // 🔹 Resources root
        public static readonly string RESOURCES_DIR = Path.Combine(ROOT_DIR, "Resources");

        // 🔹 Config
        public static readonly string CONFIG_PATH = Path.Combine(ROOT_DIR, "Config.json");

        // 🔹 Locators
        public static readonly string LOCATORS_PATH = Path.Combine(ROOT_DIR, "locators.json");

        // 🔹 Test Data
        public static readonly string TESTDATA_PATH = Path.Combine(ROOT_DIR, "testdata.json");

        // 🔹 Chrome Driver
        public static readonly string CHROME_DRIVER_PATH = Path.Combine(RESOURCES_DIR, "chromedriver.exe");

        // 🔹 Firefox Driver
        public static readonly string FIREFOX_DRIVER_PATH = Path.Combine(RESOURCES_DIR, "geckodriver.exe");

        // 🔹 Edge Driver
        public static readonly string EDGE_DRIVER_PATH = Path.Combine(RESOURCES_DIR, "msedgedriver.exe");

        public static readonly string EXTENT_PATH = Path.Combine(ROOT_DIR, "ExtentReports");

        // 🔹 Edge Driver
        public static readonly string REPORT_PATH = Path.Combine(ROOT_DIR, "Reports");
    }
}
