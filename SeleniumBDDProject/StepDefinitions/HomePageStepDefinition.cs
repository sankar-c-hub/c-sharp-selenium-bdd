using TechTalk.SpecFlow;
using NUnit.Framework;
using SeleniumBDDProject.Utility;

namespace SeleniumBDDProject.StepDefinitions
{
    [Binding]
    public class HomePageStepDefinition
    {

        [Given(@"I have access to the application")]
        public void GivenIHaveAccessToApplication()
        {
            WebManager.OpenBrowser();
            string url = FileUtility.GetConfigValue("Url");
            WebManager.GoToUrl(url);
        }
    }
}
