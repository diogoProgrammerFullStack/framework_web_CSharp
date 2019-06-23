//using NUnit.Framework;
//using System;

//namespace Mark7.Tests
//{


//    class CadastroTarefasTests : BaseTest
//    {


//        [SetUp]
//        public void BeforeExclusivoParaCenarioCadastro()
//        {
//            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
//            loginPage.Logar("diogooliveirati4@gmail.com", "41679152");
//        }

//        [Test]
//        public void DeveCadastrarUmaTarefa()
//        {
//            var tarefa = new { Titulo = "Estudar C# - " + Faker.Name.First(), Data = "30/05/2019" };
//            tarefasPage.NovaTarefa(tarefa.Titulo, tarefa.Data);

//            var results = tarefasPage.RetornaRegistro(tarefa.Titulo);
//            StringAssert.Contains(tarefa.Titulo, results.Text);
//        }

//        [Test]
//        public void DeveExibirTarefaDuplicada()
//        {
//            var tarefa = new { Titulo = "Tarefa Duplicada - " + Faker.Name.First(), Data = "30/05/2019" };

//            tarefasPage.NovaTarefa(tarefa.Titulo, tarefa.Data);
//            tarefasPage.NovaTarefa(tarefa.Titulo, tarefa.Data);

//            Assert.AreEqual("Tarefa duplicada.", tarefasPage.RetornaAlerta());
  
//        }

//        [Test]
//        public void QuandoDuplicadoDeveExibirSomenteUmRegistro()
//        {
//            var tarefa = new { Titulo = "Tarefa Duplicada - " + Faker.Name.First(), Data = "30/05/2019" };

//            tarefasPage.NovaTarefa(tarefa.Titulo, tarefa.Data);
//            tarefasPage.NovaTarefa(tarefa.Titulo, tarefa.Data);

//            tarefasPage.VoltaCadastro();
//            tarefasPage.BuscaTarefa(tarefa.Titulo);

//            Assert.AreEqual(1, tarefasPage.RetornaQuantidadeRegistro());
            
//        }

//        [Test]
//        public void QuandoTituloTarefaCurtoDeveExibirAlerta()
//        {
//            var tarefa = new { Titulo = "abcdefg", Data = "08/06/2019" };

//            tarefasPage.NovaTarefa(tarefa.Titulo, tarefa.Data);
//            Assert.AreEqual("10 caracteres é o mínimo permitido.", tarefasPage.RetornaMsgCaracterMaximo());
//        }

//    }
//}
