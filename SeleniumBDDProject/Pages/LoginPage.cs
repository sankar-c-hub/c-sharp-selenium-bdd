using OpenQA.Selenium;
using SeleniumBDDProject.Utility;
using System;

namespace SeleniumBDDProject.Pages
{
    public class LoginPage
    {
        public static IWebElement UserNameElement
        {
            get
            {
                var locator = FileUtility.GetLocatorFromYMLKey("LoginPage.usernamexpath");
                return locator.HasValue ? WebBrowserUtil.GetElement(locator.Value.byType, locator.Value.locatorValue) : null;
            }
        }

        public static IWebElement PasswordElement
        {
            get
            {
                var locator = FileUtility.GetLocatorFromYMLKey("LoginPage.passwordxpath");
                return locator.HasValue ? WebBrowserUtil.GetElement(locator.Value.byType, locator.Value.locatorValue) : null;
            }
        }

        public static IWebElement LoginButtonElement
        {
            get
            {
                var locator = FileUtility.GetLocatorFromYMLKey("LoginPage.loginbuttonxpath");
                return locator.HasValue ? WebBrowserUtil.GetElement(locator.Value.byType, locator.Value.locatorValue) : null;
            }
        }
    }
}
