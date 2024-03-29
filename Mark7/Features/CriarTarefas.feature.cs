﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Mark7.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Criar Tarefas")]
    public partial class CriarTarefasFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CriarTarefas.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt"), "Criar Tarefas", "\tPara que eu possa gerenciar minhas atividades do dia a dia\r\n\tSendo um usuário ca" +
                    "dastrado\r\n\tPosso criar novas tarefas", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 8
 #line 9
  testRunner.Given("que estou logado com \'diogooliveirati4@gmail.com\' e \'41679152\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Nova Tarefa")]
        public virtual void NovaTarefa()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Nova Tarefa", null, ((string[])(null)));
#line 11
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 this.FeatureBackground();
#line 13
  testRunner.And("que \'Revisar as aulas\' é a minha nova tarefa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 14
  testRunner.And("esta tarefa deve ser concluida até \'04/04/2020\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "tags"});
            table1.AddRow(new string[] {
                        "csharp"});
            table1.AddRow(new string[] {
                        "programacao"});
            table1.AddRow(new string[] {
                        "specflow"});
#line 15
  testRunner.And("quero taguear esta tarefa com:", ((string)(null)), table1, "E ");
#line 20
  testRunner.When("eu faço o cadastro desta tarefa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 21
  testRunner.Then("um novo registro deve ser inserido na lista de tarefas", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Tarefa duplicada")]
        public virtual void TarefaDuplicada()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Tarefa duplicada", null, ((string[])(null)));
#line 24
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 this.FeatureBackground();
#line 26
  testRunner.And("que \'Estudar MongoDB\' é a minha nova tarefa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 27
  testRunner.And("esta tarefa deve ser concluida até \'04/04/2020\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 28
  testRunner.But("eu ja cadastrei esta tarefa e não tinha percebido", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Mas ");
#line 29
  testRunner.When("eu faço o cadastro desta tarefa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 30
  testRunner.Then("devo ver a mensagem de alerta \'Tarefa duplicada.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line 31
  testRunner.And("devo ver somente 1 registro com o nome desta tarefa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Titulo muito curto")]
        public virtual void TituloMuitoCurto()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Titulo muito curto", null, ((string[])(null)));
#line 33
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 this.FeatureBackground();
#line 35
  testRunner.And("que \'123456789\' é a minha nova tarefa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 36
  testRunner.And("esta tarefa deve ser concluida até \'04/04/2020\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 37
  testRunner.When("eu faço o cadastro desta tarefa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 38
  testRunner.Then("devo ver a mensagem de alerta \'10 caracteres é o mínimo permitido.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

