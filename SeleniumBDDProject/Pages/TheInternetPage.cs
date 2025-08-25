using OpenQA.Selenium;
using SeleniumBDDProject.Utility;
using System;


namespace SeleniumBDDProject.Pages
{
    public class TheInternetPage
    {

        public static IWebElement? AddRemoveElement()
        {
            var locator = FileUtility.GetLocatorFromYMLKey("The Internet.Add_RemoveButtonXPATH");
            return locator.HasValue ? WebBrowserUtil.GetElement(locator.Value.byType, locator.Value.locatorValue) : null;
        }

        public static IWebElement? UserNameTextBoxElement()
        {
            var locator = FileUtility.GetLocatorFromYMLKey("The Internet.textboxTextBoxXPATH");
            return locator.HasValue ? WebBrowserUtil.GetElement(locator.Value.byType, locator.Value.locatorValue) : null;
        }

        public static IWebElement? PasswordElement()
        {
            var locator = FileUtility.GetLocatorFromYMLKey("The Internet.Enable_disableButtonXPATH");
            return locator.HasValue ? WebBrowserUtil.GetElement(locator.Value.byType, locator.Value.locatorValue) : null;
        }

        public static IWebElement? CheckboxElement()
        {
            var locator = FileUtility.GetLocatorFromYMLKey("New Feature.Checkbox1CheckBox");
            return locator.HasValue ? WebBrowserUtil.GetElement(locator.Value.byType, locator.Value.locatorValue) : null;
        }
    }
}
