//using NUnit.Framework;

//namespace Mark7.Tests
//{
//    public class LoginTests : BaseTest
//    {

//        [Test]
//        public void DeveExibirSenhaInvalida()
//        {

//            loginPage.Logar("diogooliveirati4@gmail.com", "@abcde");
//            Assert.AreEqual("Senha inválida.", loginPage.Notificacao().Text);
 
//        }

//        [Test]
//        public void DeveExibirUsuarioNaoCadastrado()
//        {

//            loginPage.Logar("diogooliveirati3@gmail.com", "@12345");
//            Assert.AreEqual("Usuário não cadastrado.", loginPage.Notificacao().Text);

//        }

//        [Test]
//        public void DeveExibirEmailIncorreto()
//        {

//            loginPage.Logar("404*papito.io", "@12345");
//            Assert.AreEqual("Email incorreto ou ausente.", loginPage.Notificacao().Text);

//        }

//        [Test]
//        public void DeveExibirEmailAusente()
//        {
//            loginPage.Logar("", "41679152");
//            Assert.AreEqual("Email incorreto ou ausente.", loginPage.Notificacao().Text);
//        }

//        [Test]
//        public void DeveExibirSenhaAusente()
//        {
//            loginPage.Logar("diogooliveirati4@gmail.com", "");
//            Assert.AreEqual("Senha ausente.", loginPage.Notificacao().Text);
//        }

//        [Test]
//        public void DevoLogarComSucesso()
//        {

//            loginPage.Logar("diogooliveirati4@gmail.com", "41679152");
//            tarefasPage.BemVindo();

//            Assert.AreEqual("Olá, Diogo de OliveiraJulião", tarefasPage.BemVindo().Text);
//        }
//    }
//}
