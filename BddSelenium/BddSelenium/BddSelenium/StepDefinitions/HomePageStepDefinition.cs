using BddSelenium.WorkFlows;
using TechTalk.SpecFlow;

namespace BddSelenium.StepDefinitions
{
    [Binding]
    public class HomePageStepDefinition
    {

        [Given(@"I have access to application")]
        public void GivenIHaveAccessToApplication()
        {
            HomePageWorkFlow homepageWorkFlow = new HomePageWorkFlow();
            homepageWorkFlow.loginPageaccesstopage();

        }
    }
}