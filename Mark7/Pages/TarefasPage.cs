using Mark7.Common;
using OpenQA.Selenium;
using System.Linq;

namespace Mark7.Pages
{
    public class TarefasPage
    {
        private readonly IWebDriver _driver;

        public TarefasPage(IWebDriver driver)
        {
            _driver = driver;
            
        }

        public IWebElement BemVindo()
        {
            return _driver.FindElement(By.CssSelector("#task-board .panel-body h3"));
        }

        public void NovaTarefa(string titulo, string data)
        {
            _driver.FindElement(By.Id("insert-button")).Click();
            _driver.FindElement(By.CssSelector("input[name=title]")).SendKeys(titulo);
            _driver.FindElement(By.CssSelector("input[name=dueDate]")).SendKeys(data);
            _driver.FindElement(By.CssSelector("button[type=submit]")).Click();

        }

        public IWebElement RetornaRegistro(string titulo)
        {
            var trs = _driver.FindElements(By.CssSelector("table tbody tr"));
            var alvo = trs.FirstOrDefault(tr => tr.Text.Contains(titulo));

            if (alvo == null)
            {
                throw new System.ArgumentException("Erro ao buscar a tarefa cadastrada");
            }

            return alvo;
        }

        public void SolicitaExclusaoTarefaPorTitulo(string titulo)
        {
            var resultado = this.RetornaRegistro(titulo);
            resultado.FindElement(By.Id("delete-button")).Click();
        }

        public void ConfirmaExlusaoDeTarefa()
        {
            _driver.FindElement(By.CssSelector(".modal-content button[data-bb-handler=success]")).Click();
        }

        public void DesisteDaExclusaoDeTarefa()
        {
            _driver.FindElement(By.CssSelector(".modal-content button[data-bb-handler=danger]")).Click();
        }

        public string RetornaAlerta()
        {
           return _driver.FindElement(By.CssSelector(".alert-warn div")).Text;
        }

        public void VoltaCadastro()
        {
            _driver.FindElement(By.LinkText("Voltar")).Click();
        }

        public void BuscaTarefa(string tituloTarefa)
        {
            var campoBusca = _driver.FindElement(By.CssSelector("input[type=text]"));
            campoBusca.SendKeys(tituloTarefa);
            //campoBusca.Submit(); Submete o formulário sem precisar clicar em enviar
            _driver.FindElement(By.Id("search-button")).Click();
        }

        public string RetornaAlertaTarefaNaoEncontrada()
        {
            return _driver.FindElement(By.CssSelector(".panel-c-warning div")).Text;
        }

        public int RetornaQuantidadeRegistro()
        {
            var trs = _driver.FindElements(By.CssSelector("table tbody tr"));
            return trs.Count;
        }

        public string RetornaMsgCaracterMaximo()
        {
            return _driver.FindElement(By.CssSelector(".panel-body")).Text;

        }

    }
   
}
