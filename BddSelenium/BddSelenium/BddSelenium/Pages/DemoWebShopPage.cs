using BddSelenium.Common;
using OpenQA.Selenium;

namespace BddSelenium.Pages
{
    class DemoWebShopPage : BasePage
    {
        public DemoWebShopPage(IWebDriver browser) : base(browser) { }

        public IWebElement BooksLink
        {
            get
            {
                return BrowserManagerUtil.GetElement("xpath", CommonUtil.GetObjectData("Demo Web Shop", "BooksLinkXPATH"));
            }
        }

        public IWebElement ComputersLink
        {
            get
            {
                return BrowserManagerUtil.GetElement("xpath", CommonUtil.GetObjectData("Demo Web Shop", "ComputersLinkXPATH"));
            }
        }

        public IWebElement ElectronicsLink
        {
            get
            {
                return BrowserManagerUtil.GetElement("xpath", CommonUtil.GetObjectData("Demo Web Shop", "ElectronicsLinkXPATH"));
            }
        }

        public IWebElement ApparelShoesLink
        {
            get
            {
                return BrowserManagerUtil.GetElement("xpath", CommonUtil.GetObjectData("Demo Web Shop", "ApparelShoesLinkXPATH"));
            }
        }

        public IWebElement DigitalDownloadsLink
        {
            get
            {
                return BrowserManagerUtil.GetElement("xpath", CommonUtil.GetObjectData("Demo Web Shop", "DigitaldownloadsLinkXPATH"));
            }
        }

        public IWebElement JewelryLink
        {
            get
            {
                return BrowserManagerUtil.GetElement("xpath", CommonUtil.GetObjectData("Demo Web Shop", "JewelryLinkXPATH"));
            }
        }

        public IWebElement GiftCardsLink
        {
            get
            {
                return BrowserManagerUtil.GetElement("xpath", CommonUtil.GetObjectData("Demo Web Shop", "GiftCardsLinkXPATH"));
            }
        }

        public IWebElement MessageLabel
        {
            get
            {
                return BrowserManagerUtil.GetElement("xpath", CommonUtil.GetObjectData("Demo Web Shop", "messageLabeltext"));
            }
        }
    }
}
