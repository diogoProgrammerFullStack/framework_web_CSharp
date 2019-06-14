using Mark7.Common;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Mark7.Steps
{
    [Binding]
    public sealed class LoginSteps : BaseSteps
    {

        [When(@"eu faço login com '(.*)' e '(.*)'")]
        public void QuandoEuFacoLoginComE(string email, string senha)
        {
            loginPage.Logar(email, senha);
        }

        [Then(@"devo ver a mensagem de boas vindas '(.*)'")]
        public void EntaoDevoVerAMensagemDeBoasVindas(string ola)
        {
            tarefasPage.BemVindo();
            Assert.AreEqual(ola, tarefasPage.BemVindo().Text);
        }

        [Then(@"devo ver a mensagem de notificação '(.*)'")]
        public void EntaoDevoVerAMensagemDeNotificacao(string notificacao)
        {
            Assert.AreEqual(notificacao, loginPage.Notificacao().Text);
        }
    }
}
