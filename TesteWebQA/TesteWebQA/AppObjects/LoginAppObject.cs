using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteWebQA.Drivers;

namespace TesteWebQA.AppObjects
{
    class LoginAppObject
    {
        public LoginAppObject() { }
        public IWebElement GetLoginPanelElement()
        {
            return Browser.GetWebDriver().FindElement(By.Id("logInPanelHeading"));
        }

        public IWebElement GetUserTextField()
        {
            return Browser.GetWebDriver().FindElement(By.Id("txtUsername"));
        }

        public IWebElement GetPasswordTextField()
        {
            return Browser.GetWebDriver().FindElement(By.Id("txtPassword"));
        }

        public IWebElement GetLoginButton()
        {
            return Browser.GetWebDriver().FindElement(By.Id("btnLogin"));
        }

        public IWebElement GetWelcomeElement()
        {
            return Browser.GetWebDriver().FindElement(By.Id("welcome"));
        }

        public IWebElement GetLogoutButton()
        {
            return Browser.GetWebDriver().FindElement(By.XPath(GetLogoutElement()));
        }

        public IWebElement GetSapanMessage()
        {
            return Browser.GetWebDriver().FindElement(By.Id("spanMessage"));
        }

        public string GetLogoutElement()
        {
            return "//div[@id='welcome-menu']/ul/li[2]/a";
        }
    }
}
