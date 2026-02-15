using OpenQA.Selenium;

namespace BddSelenium.Pages
{
	public class BasePage
	{
		protected IWebDriver _browser = null;
		 public BasePage(IWebDriver browser)
		 {
			_browser = browser;
		 }
	}
}
