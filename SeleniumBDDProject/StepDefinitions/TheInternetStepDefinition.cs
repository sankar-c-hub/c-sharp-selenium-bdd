using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumBDDProject.Pages;
using SeleniumBDDProject.Utility;
using TechTalk.SpecFlow;

namespace SeleniumBDDProject.StepDefinitions
{
    [Binding]
    public class InternetStepDefinitions
    {
        [When(@"I enter username as '(.*)'")]
        public void WhenIEnteredUsernametb(String username)
        {
            var element = LoginPage.UserNameElement;
            WebBrowserUtil.EnterValue(element, username);

        }

        [When(@"I enter password as '(.*)'")]
        public void WhenIEnterPasswordAs(String password)
        {
            var element = LoginPage.PasswordElement;
            WebBrowserUtil.EnterValue(element, password);

        }


        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            var element = LoginPage.LoginButtonElement;
            WebBrowserUtil.ClickElement(element);
        }

    }
}
