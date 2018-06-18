using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace TesteWebQA.Drivers
{
    public static class Browser
    {
        private const string path = @"C:\Selenium\";
        private static IWebDriver webDriver;
        private static BrowsersType browserType;
        private static string url;

        public static IWebDriver OpenBrowser(BrowsersType browser, string urlPath)
        {
            browserType = browser;
            url = urlPath;
            switch (browser)
            {
                case BrowsersType.FIREFOX:
                    return GetFirefoxDriver();
                case BrowsersType.CHROME:
                    return GetChromeDriver();
                default:
                    string invalidBrowserMessage = "Browser " + browser + " inexistente ou indisponível.";
                    throw new ArgumentException(invalidBrowserMessage);
            }
        }

        public static void CloseBrowser()
        {
            webDriver.Manage().Cookies.DeleteAllCookies();
            webDriver.Quit();
        }

        public static IWebDriver GetWebDriver()
        {
            if (webDriver == null)
            {
                OpenBrowser(browserType, url);
            }
            return webDriver;
        }

        private static IWebDriver GetFirefoxDriver()
        {
            throw new NotImplementedException("Método não implementado.");
        }

        private static IWebDriver GetChromeDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            return SetWebDriver(new ChromeDriver(options), "webdriver.chrome.driver");
        }

        public static void WaitElementAppear(By by)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(60));
            wait.Until(d => d.FindElement(by).Enabled && d.FindElement(by).Displayed);
        }

        private static IWebDriver SetWebDriver(IWebDriver driver, string environment)
        {
           // Environment.SetEnvironmentVariable(environment, path);
           // driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            driver.Url = url;

            webDriver = driver;
            return webDriver;
        }
    }
}
