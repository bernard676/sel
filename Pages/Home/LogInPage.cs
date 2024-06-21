using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Pages.Home
{
    public  class LogInPage
    {
        //Locators
        [FindsBy(How = How.CssSelector, Using = "#small-searchterms")]
        private IWebElement SearchStoreInput; 
        
        [FindsBy(How = How.XPath, Using = "//input[@value='Search']")]
        private IWebElement SearchButton;   

        public void isAt()
        {
            Assert.That(Browser.Title, Is.EqualTo("nopCommerce demo store"));
        }

        public void EnterSearchText(string searchText)
        {
            Assert.IsTrue(SearchStoreInput.Displayed);
            SearchStoreInput.SendKeys(searchText);
        }
    }
}
