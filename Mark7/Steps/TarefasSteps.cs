using Mark7.Common;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Mark7.Steps
{
    public class Tarefa
    {
        public string Titulo { get; set; }
        public string Data { get; set; }
        public List<String> Tags = new List<string>();
    }

    [Binding]
    public sealed class TarefasSteps : BaseSteps
    {
        private Tarefa novaTarefa = new Tarefa();

        [Given(@"que estou logado com '(.*)' e '(.*)'")]
        public void DadoQueEstouLogadoComE(string email, string senha)
        {
            loginPage.Logar(email, senha);
        }

        [Given(@"que '(.*)' é a minha nova tarefa")]
        public void DadoQueEAMinhaNovaTarefa(string titulo)
        {
            novaTarefa.Titulo = titulo;
        }

        [Given(@"esta tarefa deve ser concluida até '(.*)'")]
        public void DadoEstaTarefaDeveSerConcluidaAte(string data)
        {
            novaTarefa.Data = data;
        }

        [Given(@"quero taguear esta tarefa com:")]
        public void DadoQueroTaguearEstaTarefaCom(Table table)
        {

            foreach(var item in table.Rows)
            {
                novaTarefa.Tags.Add(item["tags"]);
            }
        }

        [When(@"eu faço o cadastro desta tarefa")]
        public void QuandoEuFacoOCadastroDestaTarefa()
        {
            tarefasPage.NovaTarefa2(novaTarefa);
        }

        [Then(@"um novo registro deve ser inserido na lista de tarefas")]
        public void EntaoUmNovoRegistroDeveSerInseridoNaListaDeTarefas()
        {
            var results = tarefasPage.RetornaRegistro(novaTarefa.Titulo);
            StringAssert.Contains(novaTarefa.Titulo, results.Text);
        }

        [Given(@"eu ja cadastrei esta tarefa e não tinha percebido")]
        public void DadoEuJaCadastreiEstaTarefaENaoTinhaPercebido()
        {
            tarefasPage.NovaTarefa2(novaTarefa);
        }

        [Then(@"devo ver a mensagem de alerta '(.*)'")]
        public void EntaoDevoVerAMensagemDeAlerta(string alerta)
        {
            Assert.AreEqual(alerta, tarefasPage.RetornaAlerta());
        }

        [Then(@"devo ver somente (.*) registro com o nome desta tarefa")]
        public void EntaoDevoVerSomenteRegistroComONomeDestaTarefa(int quantidade)
        {
            tarefasPage.VoltaCadastro();
            tarefasPage.BuscaTarefa(novaTarefa.Titulo);

            Assert.AreEqual(quantidade, tarefasPage.RetornaQuantidadeRegistro());
        }

        //RemoverTarefas

        [When(@"eu remover está tarefa '(.*)'")]
        public void QuandoEuRemoverEstaTarefa(string titulo)
        {
            tarefasPage.SolicitaExclusaoTarefaPorTitulo(titulo);
            tarefasPage.ConfirmaExlusaoDeTarefa();
        }

        [Then(@"deve exibir a mensagem '(.*)'")]
        public void EntaoDeveExibirAMensagem(string msgResultado)
        {
            tarefasPage.BuscaTarefa(novaTarefa.Titulo);
            Assert.AreEqual(msgResultado, tarefasPage.RetornaAlertaTarefaNaoEncontrada());
        }
    }
}
