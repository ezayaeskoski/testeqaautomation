using NUnit.Framework;
using TechTalk.SpecFlow;
using TesteWebQA.Drivers;
using TesteWebQA.Tasks;
using TesteWebQA.VerificationPoints;

namespace TesteWebQA.Test.Steps
{
    [Binding]
    public sealed class LoginSteps
    {
        private LoginTask login;
        private LoginVerificationPoint verification;

        [Given(@"que acesso o sistema OrangeHRM")]
        public void DadoQueAcessoOSistemaOrangeHRM()
        {
            Browser.OpenBrowser(BrowsersType.CHROME, "http://opensource.demo.orangehrmlive.com/");
        }

        [Given(@"que esteja na página de Login")]
        public void DadoQueEstejaNaPaginaDeLogin()
        {
            login = new LoginTask();
            Assert.True(login.IsLoginPage());
        }

        [When(@"inserir os dados de ""(.*)"" e ""(.*)"" e efetuar o login")]
        public void QuandoInserirOsDadosDeEEEfetuarOLogin(string user, string password)
        {
            login.Logar(user, password);
        }

        [Then(@"a página inicial do sistema é apresentada")]
        public void EntaoAPaginaInicialDoSistemaEApresentada()
        {
            verification = new LoginVerificationPoint();
            verification.IsLoginSuccessfully();
        }

        [Given(@"que esteja logado no sistema")]
        public void DadoQueEstejaLogadoNoSistema()
        {
            login = new LoginTask();
            login.Logar("admin", "admin");
            Assert.True(login.IsLoggedIn());
        }

        [When(@"clicar no botão Logout")]
        public void QuandoClicarNoBotaoLogout()
        {
            login.Logout();
        }

        [Then(@"a página de login é apresentada")]
        public void EntaoAPaginaDeLoginEApresentada()
        {
            verification = new LoginVerificationPoint();
            verification.IsLogoutSuccessfully();
        }

        [AfterScenario]
        public static void FinalizoOAcessoAoMercanet()
        {
            Browser.CloseBrowser();
        }

    }
}
