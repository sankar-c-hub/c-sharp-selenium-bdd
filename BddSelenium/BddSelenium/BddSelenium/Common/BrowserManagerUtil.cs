using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace BddSelenium.Common
{
    public static class BrowserManagerUtil
    {
        // You can set this from Hooks / DriverManager
        public static IWebDriver Driver;

        // Method 1: Get element using locator type as string
        public static IWebElement GetElement(string locatorType, string locatorValue)
        {
            Driver = BrowserManager.Driver;
            switch (locatorType.ToLower())
            {
                case "id":
                    return Driver.FindElement(By.Id(locatorValue));

                case "name":
                    return Driver.FindElement(By.Name(locatorValue));

                case "xpath":
                    return Driver.FindElement(By.XPath(locatorValue));

                case "css":
                case "cssselector":
                    return Driver.FindElement(By.CssSelector(locatorValue));

                case "classname":
                    return Driver.FindElement(By.ClassName(locatorValue));

                case "tagname":
                    return Driver.FindElement(By.TagName(locatorValue));

                case "linktext":
                    return Driver.FindElement(By.LinkText(locatorValue));

                case "partiallinktext":
                    return Driver.FindElement(By.PartialLinkText(locatorValue));

                default:
                    throw new ArgumentException($"Invalid locator type: {locatorType}");
            }
        }

        // Method 2: Get element directly using By
        public static IWebElement GetElement(By by)
        {
            return Driver.FindElement(by);
        }
    }
}
