using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mark7.Tests
{
    public class ExclusaoTarefasTests : BaseTest
    {
        [SetUp]
        public void BeforeExclusivoParaCenarioCadastro()
        {
            loginPage.Logar("diogooliveirati4@gmail.com", "41679152");
        }

        [Test]
        public void DeveRemoverUmaTarefa()
        {
            var tarefa = new { Titulo = "Tarefa Boa Para ser Removida" + Faker.Name.First(), Data = "08/06/2019"};
            tarefasPage.NovaTarefa(tarefa.Titulo, tarefa.Data);

            tarefasPage.SolicitaExclusaoTarefaPorTitulo(tarefa.Titulo);
            tarefasPage.ConfirmaExlusaoDeTarefa();
            tarefasPage.BuscaTarefa(tarefa.Titulo);
            Assert.AreEqual("Hmm... nenhuma tarefa encontrada :(", tarefasPage.RetornaAlertaTarefaNaoEncontrada());

        }

        [Test]
        public void DeveDesistirDeRemoverTarefa()
        {
            var tarefa = new { Titulo = "Tarefa Para Desistir de excluir" + Faker.Name.First(),  Data = "08/06/2019" };
            tarefasPage.NovaTarefa(tarefa.Titulo, tarefa.Data);

            tarefasPage.SolicitaExclusaoTarefaPorTitulo(tarefa.Titulo);
            tarefasPage.DesisteDaExclusaoDeTarefa();
            tarefasPage.BuscaTarefa(tarefa.Titulo);
            Assert.IsNotNull(tarefa.Titulo);

            
        }

    }
}
