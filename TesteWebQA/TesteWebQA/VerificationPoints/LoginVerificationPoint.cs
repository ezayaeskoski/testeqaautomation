using FrameworkCsharp.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteWebQA.AppObjects;
using TesteWebQA.Tasks;
using TesteWebQA.Utils;

namespace TesteWebQA.VerificationPoints
{
    public class LoginVerificationPoint
    {
        private ExtentReports extent;
        private LoginTask login;

        public LoginVerificationPoint()
        {
            
            this.login = new LoginTask();
        }

        public void IsLoginSuccessfully()
        {
            extent = new ExtentReports(ProjConfig.GetPath() + "LoginTest" + DateTime.Now.ToString("ddMMyyyHHmmss") + ".html");
            var test = extent.StartTest("Login", "Teste de Login"+ DateTime.Now.ToString("ddMMyyyHHmmss"));

            if (login.InvalidMessage())
            {
                test.Log(LogStatus.Error, "Usuário ou senha inválidos" +
                                          test.AddScreenCapture(ScreenshotUtils.TakeScreenshot()));
            }

            if (login.IsLoggedIn())
            {
                test.Log(LogStatus.Pass, "Login Efetuado com sucesso" +
                                         test.AddScreenCapture(ScreenshotUtils.TakeScreenshot()));
            }
            else
            {
                test.Log(LogStatus.Error, "Login não efetuado" +
                                          test.AddScreenCapture(ScreenshotUtils.TakeScreenshot()));
            }
            EndTest(test);
            Assert.True(login.IsLoggedIn());
            
        }

        public void IsLogoutSuccessfully()
        {
            extent = new ExtentReports(ProjConfig.GetPath() + "LogoutTest" + DateTime.Now.ToString("ddMMyyyHHmmss") + ".html");
            var test = extent.StartTest("Login", "Teste de Logout" + DateTime.Now.ToString("ddMMyyyHHmmss"));

            if (login.IsLoginPage())
            {
                test.Log(LogStatus.Pass, "Logout Efetuado com sucesso" +
                                         test.AddScreenCapture(ScreenshotUtils.TakeScreenshot()));
            }
            else
            {
                test.Log(LogStatus.Error, "Logout Não efetuado" +
                                          test.AddScreenCapture(ScreenshotUtils.TakeScreenshot()));
            }
            EndTest(test);
            Assert.True(login.IsLoginPage());
            
            
        }

        private void EndTest(ExtentTest exTest)
        {
            extent.EndTest(exTest);
            extent.Flush();
            extent.Close();
        }
    }
}
