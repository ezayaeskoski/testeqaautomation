using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteWebQA.AppObjects;
using TesteWebQA.Drivers;

namespace TesteWebQA.Tasks
{
    class LoginTask
    {
        private LoginAppObject login;

        public LoginTask()
        {
            login = new LoginAppObject();
        }
        public void Logar(string user, string pass)
        {
            try
            {
                login.GetUserTextField().SendKeys(user);
                login.GetPasswordTextField().SendKeys(pass);
                login.GetLoginButton().Click();
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Elemento não localizado" + ex.Message);
            }
        }

        public void Logout()
        {
            try
            {
                login.GetWelcomeElement().Click();
                Browser.WaitElementAppear(By.XPath(login.GetLogoutElement()));
                login.GetLogoutButton().Click();
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Elemento não localizado" + ex.Message);
            }
        }

        public bool IsLoginPage()
        {
            try
            {
                return login.GetLoginPanelElement().Text.Contains("LOGIN");
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Elemento não localizado " + ex.Message);
                return false;
            }
        }

        public bool IsLoggedIn()
        {
            try
            {
                return login.GetWelcomeElement().Text.Contains("Welcome");
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Elemento não localizado " + ex.Message);
                return false;
            }
        }

        public bool InvalidMessage()
        {
            try
            {
                return (login.GetSapanMessage().Text.Contains("empty") || 
                        login.GetSapanMessage().Text.Contains("Invalid"));

            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Elemento não localizado " + ex.Message);
                return false;
            }
        }
    }
}
