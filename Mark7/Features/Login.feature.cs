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
    [NUnit.Framework.DescriptionAttribute("Login")]
    public partial class LoginFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Login.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt"), "Login", "\tSendo um usuário cadastrado\r\n\tPosso fazer login\r\n\tPara ter acesso ao meu painel " +
                    "de atividades", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Usuário autenticado")]
        public virtual void UsuarioAutenticado()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Usuário autenticado", null, ((string[])(null)));
#line 8
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 10
  testRunner.When("eu faço login com \'diogooliveirati4@gmail.com\' e \'41679152\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 11
  testRunner.Then("devo ver a mensagem de boas vindas \'Olá, Diogo de OliveiraJulião\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Senha Incorreta")]
        public virtual void SenhaIncorreta()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Senha Incorreta", null, ((string[])(null)));
#line 13
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 15
  testRunner.When("eu faço login com \'diogooliveirati4@gmail.com\' e \'@abcde\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 16
  testRunner.Then("devo ver a mensagem de notificação \'Senha inválida.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Usuário não existe")]
        public virtual void UsuarioNaoExiste()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Usuário não existe", null, ((string[])(null)));
#line 18
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 20
  testRunner.When("eu faço login com \'diogooliveirati3@gmail.com\' e \'41679152\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 21
  testRunner.Then("devo ver a mensagem de notificação \'Usuário não cadastrado.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Senha Ausente")]
        public virtual void SenhaAusente()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Senha Ausente", null, ((string[])(null)));
#line 23
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 25
  testRunner.When("eu faço login com \'diogooliveirati4@gmail.com\' e \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 26
  testRunner.Then("devo ver a mensagem de notificação \'Senha ausente.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Email Ausente")]
        public virtual void EmailAusente()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Email Ausente", null, ((string[])(null)));
#line 28
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 30
  testRunner.When("eu faço login com \'\' e \'41679152\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 31
  testRunner.Then("devo ver a mensagem de notificação \'Email incorreto ou ausente.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Email Incorreto")]
        public virtual void EmailIncorreto()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Email Incorreto", null, ((string[])(null)));
#line 33
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 35
  testRunner.When("eu faço login com \'diogooliveirati*gmail.com\' e \'41679152\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 36
  testRunner.Then("devo ver a mensagem de notificação \'Email incorreto ou ausente.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
