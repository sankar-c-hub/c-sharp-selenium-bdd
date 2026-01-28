using BddSelenium.Common;
using BddSelenium.Pages;
using Microsoft.Testing.Platform.Logging;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using System;

namespace BddSelenium.WorkFlows
{
    class DemoWebShopWorkFlow
    {
        IWebDriver browser = null;
        static string basePath = System.AppDomain.CurrentDomain.BaseDirectory;

        public void Booksclicked()
        {
            browser = BrowserManager.Driver;
            DemoWebShopPage demowebshopPage = new DemoWebShopPage(browser);
            bool staleElement = true;
            int i = 0;
            while (staleElement && i < 5)
            {
                try
                {
                    IWebElement element = demowebshopPage.BooksLink;
                    element.Click();
                    staleElement = false;
                    Hooks.log.Add($"Books clicked successfully");
                }
                catch (Exception ex)
                {
                    i++;
                    staleElement = true;
                    if (i == 4)
                    {
                        throw new CustomException("Books link not found");
                    }
                }
            }
            //browser.Wait();
        }

        public bool Booksverifydisplayed()
        {
            bool isVerified = false;
            browser = BrowserManager.Driver;
            DemoWebShopPage demowebshopPage = new DemoWebShopPage(browser);
            try
            {
                isVerified = demowebshopPage.BooksLink.Displayed;
                Hooks.log.Add("Books is displayed");
            }
            catch
            {
                isVerified = false;
            }
            return isVerified;
        }

        public bool Computersverifydisplayed()
        {
            bool isVerified = false;
            browser = BrowserManager.Driver;
            DemoWebShopPage demowebshopPage = new DemoWebShopPage(browser);
            try
            {
                isVerified = demowebshopPage.ComputersLink.Displayed;
                Hooks.log.Add("Computers is displayed");
            }
            catch
            {
                isVerified = false;
            }
            return isVerified;
        }

        public void Computersclicked()
        {
            browser = BrowserManager.Driver;
            DemoWebShopPage demowebshopPage = new DemoWebShopPage(browser);
            bool staleElement = true;
            int i = 0;
            while (staleElement && i < 5)
            {
                try
                {
                    demowebshopPage.ComputersLink.Click();
                    staleElement = false;
                    Hooks.log.Add($"Computers clicked successfully");
                }
                catch (Exception ex)
                {
                    i++;
                    staleElement = true;
                    if (i == 4)
                    {
                        throw new CustomException("Computers link not found");
                    }
                }
            }
            //browser.Wait();
        }

        public void Electronicsclicked()
        {
            browser = BrowserManager.Driver;
            DemoWebShopPage demowebshopPage = new DemoWebShopPage(browser);
            bool staleElement = true;
            int i = 0;
            while (staleElement && i < 5)
            {
                try
                {
                    demowebshopPage.ElectronicsLink.Click();
                    staleElement = false;
                    Hooks.log.Add($"Electronics clicked successfully");
                }
                catch (Exception ex)
                {
                    i++;
                    staleElement = true;
                    if (i == 4)
                    {
                        throw new CustomException("Electronics link not found");
                    }
                }
            }
            //browser.Wait();
        }

        public bool Electronicsverifydisplayed()
        {
            bool isVerified = false;
            browser = BrowserManager.Driver;
            DemoWebShopPage demowebshopPage = new DemoWebShopPage(browser);
            try
            {
                isVerified = demowebshopPage.ElectronicsLink.Displayed;
                Hooks.log.Add("Electronics is displayed");
            }
            catch
            {
                isVerified = false;
            }
            return isVerified;
        }

        public void ApparelShoesclicked()
        {
            browser = BrowserManager.Driver;
            DemoWebShopPage demowebshopPage = new DemoWebShopPage(browser);
            bool staleElement = true;
            int i = 0;
            while (staleElement && i < 5)
            {
                try
                {
                    demowebshopPage.ApparelShoesLink.Click();
                    staleElement = false;
                    Hooks.log.Add($"ApparelShoes clicked successfully");
                }
                catch (Exception ex)
                {
                    i++;
                    staleElement = true;
                    if (i == 4)
                    {
                        throw new CustomException("ApparelShoes link not found");
                    }
                }
            }
            //browser.Wait();
        }

        public bool ApparelShoesverifydisplayed()
        {
            bool isVerified = false;
            browser = BrowserManager.Driver;
            DemoWebShopPage demowebshopPage = new DemoWebShopPage(browser);
            try
            {
                isVerified = demowebshopPage.ApparelShoesLink.Displayed;
                Hooks.log.Add("ApparelShoes is displayed");
            }
            catch
            {
                isVerified = false;
            }
            return isVerified;
        }

        public void Digitaldownloadsclicked()
        {
            browser = BrowserManager.Driver;
            DemoWebShopPage demowebshopPage = new DemoWebShopPage(browser);
            bool staleElement = true;
            int i = 0;
            while (staleElement && i < 5)
            {
                try
                {
                    demowebshopPage.DigitalDownloadsLink.Click();
                    staleElement = false;
                    Hooks.log.Add($"DigitalDownloads clicked successfully");
                }
                catch (Exception ex)
                {
                    i++;
                    staleElement = true;
                    if (i == 4)
                    {
                        throw new CustomException("Digitaldownloads link not found");
                    }
                }
            }
            //browser.Wait();
        }

        public bool Digitaldownloadsverifydisplayed()
        {
            bool isVerified = false;
            browser = BrowserManager.Driver;
            DemoWebShopPage demowebshopPage = new DemoWebShopPage(browser);
            try
            {
                isVerified = demowebshopPage.DigitalDownloadsLink.Displayed;
                Hooks.log.Add("DigitalDownloads is displayed");
            }
            catch
            {
                isVerified = false;
            }
            return isVerified;
        }

        public void Jewelryclicked()
        {
            browser = BrowserManager.Driver;
            DemoWebShopPage demowebshopPage = new DemoWebShopPage(browser);
            bool staleElement = true;
            int i = 0;
            while (staleElement && i < 5)
            {
                try
                {
                    demowebshopPage.JewelryLink.Click();
                    staleElement = false;
                    Hooks.log.Add($"Jewelry clicked successfully");
                }
                catch (Exception ex)
                {
                    i++;
                    staleElement = true;
                    if (i == 4)
                    {
                        throw new CustomException("Jewelry link not found");
                    }
                }
            }
            //browser.Wait();
        }

        public bool Jewelryverifydisplayed()
        {
            bool isVerified = false;
            browser = BrowserManager.Driver;
            DemoWebShopPage demowebshopPage = new DemoWebShopPage(browser);
            try
            {
                isVerified = demowebshopPage.JewelryLink.Displayed;
                Hooks.log.Add("Jewelry is displayed");
            }
            catch
            {
                isVerified = false;
            }
            return isVerified;
        }

        public void GiftCardsclicked()
        {
            browser = BrowserManager.Driver;
            DemoWebShopPage demowebshopPage = new DemoWebShopPage(browser);
            bool staleElement = true;
            int i = 0;
            while (staleElement && i < 5)
            {
                try
                {
                    demowebshopPage.GiftCardsLink.Click();
                    staleElement = false;
                    Hooks.log.Add($"GiftCards clicked successfully");
                }
                catch (Exception ex)
                {
                    i++;
                    staleElement = true;
                    try
                    {
                        demowebshopPage.GiftCardsLink.Click();
                        staleElement = false;
                    }
                    catch (Exception Ex)
                    {
                        Console.WriteLine($"Unexpected error on retry Exception: {ex.Message}");
                        i++;
                    }
                    if (i == 4)
                    {
                        throw new CustomException("GiftCards link not found");
                    }
                }
            }
            //browser.Wait();
        }

        public bool GiftCardsverifydisplayed()
        {
            bool isVerified = false;
            browser = BrowserManager.Driver;
            DemoWebShopPage demowebshopPage = new DemoWebShopPage(browser);
            try
            {
                isVerified = demowebshopPage.GiftCardsLink.Displayed;
                Hooks.log.Add("GiftCards is displayed");
            }
            catch
            {
                isVerified = false;
            }
            return isVerified;
        }

        public bool Defaultpagedisplayed(string var_page)
        {
            bool isVerified = true;

            return isVerified;
        }

        public bool messagedisplayed(string content)
        {
            bool isVerified = true;
            return isVerified;
        }

    }
}