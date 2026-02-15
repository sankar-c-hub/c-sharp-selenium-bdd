using TechTalk.SpecFlow;
using BddSelenium.WorkFlows;
using BddSelenium.Common;

namespace BddSelenium.StepDefinitions
{
    [Binding]
    public class DemoWebShopStepDefinition
    {

        [When(@"I clicked Books in demo web shop")]
        public void WhenIClickedBooksInDemoWebShop()
        {
            DemoWebShopWorkFlow demowebshopWorkFlow = new DemoWebShopWorkFlow();
            demowebshopWorkFlow.Booksclicked();

        }
        [Then(@"verify displayed Books in demo web shop")]
        public void ThenVerifyDisplayedBooksInDemoWebShop()
        {
            DemoWebShopWorkFlow demowebshopWorkFlow = new DemoWebShopWorkFlow();
            Assertion.IsTrue(demowebshopWorkFlow.Booksverifydisplayed(), "Then verify displayed Books in demo web shop");

        }
        [Then(@"verify displayed Computers in demo web shop")]
        public void ThenVerifyDisplayedComputersInDemoWebShop()
        {
            DemoWebShopWorkFlow demowebshopWorkFlow = new DemoWebShopWorkFlow();
            Assertion.IsTrue(demowebshopWorkFlow.Computersverifydisplayed(), "Then verify displayed Computers in demo web shop");

        }
        [When(@"I clicked Computers in demo web shop")]
        public void WhenIClickedComputersInDemoWebShop()
        {
            DemoWebShopWorkFlow demowebshopWorkFlow = new DemoWebShopWorkFlow();
            demowebshopWorkFlow.Computersclicked();

        }
        [When(@"I clicked Electronics in demo web shop")]
        public void WhenIClickedElectronicsInDemoWebShop()
        {
            DemoWebShopWorkFlow demowebshopWorkFlow = new DemoWebShopWorkFlow();
            demowebshopWorkFlow.Electronicsclicked();

        }
        [Then(@"verify displayed Electronics in demo web shop")]
        public void ThenVerifyDisplayedElectronicsInDemoWebShop()
        {
            DemoWebShopWorkFlow demowebshopWorkFlow = new DemoWebShopWorkFlow();
            Assertion.IsTrue(demowebshopWorkFlow.Electronicsverifydisplayed(), "Then verify displayed Electronics in demo web shop");

        }
        [When(@"I clicked Apparel Shoes in demo web shop")]
        public void WhenIClickedApparelShoesInDemoWebShop()
        {
            DemoWebShopWorkFlow demowebshopWorkFlow = new DemoWebShopWorkFlow();
            demowebshopWorkFlow.ApparelShoesclicked();

        }
        [Then(@"verify displayed Apparel Shoes in demo web shop")]
        public void ThenVerifyDisplayedApparelShoesInDemoWebShop()
        {
            DemoWebShopWorkFlow demowebshopWorkFlow = new DemoWebShopWorkFlow();
            Assertion.IsTrue(demowebshopWorkFlow.ApparelShoesverifydisplayed(), "Then verify displayed Apparel Shoes in demo web shop");

        }
        [When(@"I clicked Digital downloads in demo web shop")]
        public void WhenIClickedDigitalDownloadsInDemoWebShop()
        {
            DemoWebShopWorkFlow demowebshopWorkFlow = new DemoWebShopWorkFlow();
            demowebshopWorkFlow.Digitaldownloadsclicked();

        }
        [Then(@"verify displayed Digital downloads in demo web shop")]
        public void ThenVerifyDisplayedDigitalDownloadsInDemoWebShop()
        {
            DemoWebShopWorkFlow demowebshopWorkFlow = new DemoWebShopWorkFlow();
            Assertion.IsTrue(demowebshopWorkFlow.Digitaldownloadsverifydisplayed(), "Then verify displayed Digital downloads in demo web shop");

        }
        [When(@"I clicked Jewelry in demo web shop")]
        public void WhenIClickedJewelryInDemoWebShop()
        {
            DemoWebShopWorkFlow demowebshopWorkFlow = new DemoWebShopWorkFlow();
            demowebshopWorkFlow.Jewelryclicked();

        }
        [Then(@"verify displayed Jewelry in demo web shop")]
        public void ThenVerifyDisplayedJewelryInDemoWebShop()
        {
            DemoWebShopWorkFlow demowebshopWorkFlow = new DemoWebShopWorkFlow();
            Assertion.IsTrue(demowebshopWorkFlow.Jewelryverifydisplayed(), "Then verify displayed Jewelry in demo web shop");

        }
        [When(@"I clicked Gift Cards in demo web shop")]
        public void WhenIClickedGiftCardsInDemoWebShop()
        {
            DemoWebShopWorkFlow demowebshopWorkFlow = new DemoWebShopWorkFlow();
            demowebshopWorkFlow.GiftCardsclicked();

        }
        [Then(@"verify displayed Gift Cards in demo web shop")]
        public void ThenVerifyDisplayedGiftCardsInDemoWebShop()
        {
            DemoWebShopWorkFlow demowebshopWorkFlow = new DemoWebShopWorkFlow();
            Assertion.IsTrue(demowebshopWorkFlow.GiftCardsverifydisplayed(), "Then verify displayed Gift Cards in demo web shop");

        }
        [Then(@"'(.*)' is displayed with '(.*)'")]
        public void ThenpageIsDisplayedWithcontent(String var_page, String content)
        {
            DemoWebShopWorkFlow demowebshopWorkFlow = new DemoWebShopWorkFlow();
            Assertion.IsTrue(demowebshopWorkFlow.Defaultpagedisplayed(var_page), "Then '<page>' is displayed with '<content>'");
            Assertion.IsTrue(demowebshopWorkFlow.messagedisplayed(content), "");

        }
    }
}