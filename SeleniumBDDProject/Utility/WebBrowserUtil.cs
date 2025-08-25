using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBDDProject.Utility
{
    public class WebBrowserUtil
    {
        public static IWebElement GetElement(string byType, string locatorValue)
        {
            switch (byType.ToLower())
            {
                case "id":
                    return WebManager.GetDriver.FindElement(By.Id(locatorValue));
                case "xpath":
                    return WebManager.GetDriver.FindElement(By.XPath(locatorValue));
                case "css":
                    return WebManager.GetDriver.FindElement(By.CssSelector(locatorValue));
                case "name":
                    return WebManager.GetDriver.FindElement(By.Name(locatorValue));
                case "classname":
                    return WebManager.GetDriver.FindElement(By.ClassName(locatorValue));
                case "tagname":
                    return WebManager.GetDriver.FindElement(By.TagName(locatorValue));
                case "linktext":
                    return WebManager.GetDriver.FindElement(By.LinkText(locatorValue));
                case "partiallinktext":
                    return WebManager.GetDriver.FindElement(By.PartialLinkText(locatorValue));
                default:
                    throw new ArgumentException($"Locator type '{byType}' is not supported.");
            }
        }
        public static void EnterValue(IWebElement element, string value)
        {
            if (element != null)
            {
                element.Clear();
                element.SendKeys(value);
                Hooks.UserLogs.Add($"Entered value '{value}' into element: {element}");

            }
        }

        public static void ClickElement(IWebElement element)
        {
            if (element != null)
            {
                element.Click();
                Hooks.UserLogs.Add($"Clicked into element: {element}");
            }

        }

    }
}
