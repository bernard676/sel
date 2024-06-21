using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace Selenium
{
    public static class Browser
    {
        private static IWebDriver webDriver;
        private static string baseURL = "https://demo.nopcommerce.com/";
        private static string browser = "Chrome";
        private static Int32 timeout = 10000; // in milliseconds

        public static void Init()
        {
            switch (browser)
            {
                case "Chrome":
                    webDriver = new ChromeDriver();
                    break;
                case "Firefox":
                    webDriver = new FirefoxDriver();
                    break;
                default:
                    webDriver = new ChromeDriver();
                    break;
            }
            webDriver.Manage().Window.Maximize();
            Goto(baseURL);
            load_complete();
        }
        public static string Title
        {
            get { return webDriver.Title; }
        }
        public static IWebDriver getDriver
        {
            get { return webDriver; }
        }
        public static void Goto(string url)
        {
            //WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(2));
            //wait.Until(d => d);
            webDriver.Url = url;
        }
        public static void Close()
        {
            webDriver.Quit();
        }

        public static void load_complete()
        {
            var wait = new WebDriverWait(webDriver, TimeSpan.FromMilliseconds(timeout));
            // Wait for the page to load
            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
        }
    }
}
