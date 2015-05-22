﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Dapper.FastCrud.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CRUD tests")]
    public partial class CRUDTestsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Crud.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CRUD tests", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Insert and select all")]
        [NUnit.Framework.TestCaseAttribute("LocalDb", "employee", "1", null)]
        [NUnit.Framework.TestCaseAttribute("PostgreSql", "employee", "1", null)]
        [NUnit.Framework.TestCaseAttribute("MySql", "employee", "1", null)]
        [NUnit.Framework.TestCaseAttribute("SqLite", "workstation", "1", null)]
        [NUnit.Framework.TestCaseAttribute("LocalDb", "building", "1", null)]
        [NUnit.Framework.TestCaseAttribute("MySql", "building", "1", null)]
        [NUnit.Framework.TestCaseAttribute("PostgreSql", "building", "1", null)]
        [NUnit.Framework.TestCaseAttribute("SqLite", "building", "1", null)]
        public virtual void InsertAndSelectAll(string databaseType, string entityType, string entityCount, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Insert and select all", exampleTags);
#line 3
this.ScenarioSetup(scenarioInfo);
#line 4
 testRunner.Given(string.Format("I have initialized a {0} database", databaseType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
 testRunner.When(string.Format("I insert {0} {1} entities", entityCount, entityType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 6
 testRunner.And(string.Format("I query for all the {0} entities", entityType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 7
 testRunner.Then("the queried entities should be the same as the ones I inserted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Find")]
        [NUnit.Framework.TestCaseAttribute("LocalDb", "employee", "100", "10", "20", null)]
        [NUnit.Framework.TestCaseAttribute("MySql", "employee", "100", "10", "20", null)]
        [NUnit.Framework.TestCaseAttribute("PostgreSql", "employee", "100", "10", "20", null)]
        [NUnit.Framework.TestCaseAttribute("SqLite", "workstation", "100", "10", "20", null)]
        public virtual void Find(string databaseType, string entityType, string entityCount, string max, string skip, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Find", exampleTags);
#line 19
this.ScenarioSetup(scenarioInfo);
#line 20
 testRunner.Given(string.Format("I have initialized a {0} database", databaseType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
 testRunner.When(string.Format("I insert {0} {1} entities", entityCount, entityType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.And(string.Format("I query for a maximum of {0} {1} entities ordered by workstation id skipping {2} " +
                        "records", max, entityType, skip), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.Then(string.Format("the queried entities should be the same as the ones I inserted, in reverse order," +
                        " starting from {0} counting {1}", skip, max), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Insert and select by primary key")]
        [NUnit.Framework.TestCaseAttribute("LocalDb", "employee", "1", null)]
        [NUnit.Framework.TestCaseAttribute("MySql", "employee", "1", null)]
        [NUnit.Framework.TestCaseAttribute("PostgreSql", "employee", "1", null)]
        [NUnit.Framework.TestCaseAttribute("LocalDb", "workstation", "1", null)]
        [NUnit.Framework.TestCaseAttribute("MySql", "workstation", "1", null)]
        [NUnit.Framework.TestCaseAttribute("PostgreSql", "workstation", "1", null)]
        [NUnit.Framework.TestCaseAttribute("LocalDb", "building", "1", null)]
        [NUnit.Framework.TestCaseAttribute("MySql", "building", "1", null)]
        [NUnit.Framework.TestCaseAttribute("SqLite", "building", "1", null)]
        [NUnit.Framework.TestCaseAttribute("PostgreSql", "building", "1", null)]
        public virtual void InsertAndSelectByPrimaryKey(string databaseType, string entityType, string entityCount, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Insert and select by primary key", exampleTags);
#line 31
this.ScenarioSetup(scenarioInfo);
#line 32
 testRunner.Given(string.Format("I have initialized a {0} database", databaseType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 33
 testRunner.When(string.Format("I insert {0} {1} entities", entityCount, entityType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.And(string.Format("I query for the inserted {0} entities", entityType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.Then("the queried entities should be the same as the ones I inserted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Update by primary keys")]
        [NUnit.Framework.TestCaseAttribute("LocalDb", "employee", "1", null)]
        [NUnit.Framework.TestCaseAttribute("MySql", "employee", "1", null)]
        [NUnit.Framework.TestCaseAttribute("PostgreSql", "employee", "1", null)]
        [NUnit.Framework.TestCaseAttribute("LocalDb", "workstation", "1", null)]
        [NUnit.Framework.TestCaseAttribute("MySql", "workstation", "1", null)]
        [NUnit.Framework.TestCaseAttribute("PostgreSql", "workstation", "1", null)]
        [NUnit.Framework.TestCaseAttribute("LocalDb", "building", "1", null)]
        [NUnit.Framework.TestCaseAttribute("MySql", "building", "1", null)]
        [NUnit.Framework.TestCaseAttribute("SqLite", "building", "1", null)]
        [NUnit.Framework.TestCaseAttribute("PostgreSql", "building", "1", null)]
        public virtual void UpdateByPrimaryKeys(string databaseType, string entityType, string entityCount, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update by primary keys", exampleTags);
#line 49
this.ScenarioSetup(scenarioInfo);
#line 50
 testRunner.Given(string.Format("I have initialized a {0} database", databaseType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 51
 testRunner.When(string.Format("I insert {0} {1} entities", entityCount, entityType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 52
 testRunner.And(string.Format("I update all the inserted {0} entities", entityType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.And(string.Format("I query for all the {0} entities", entityType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.Then("the queried entities should be the same as the ones I updated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Delete by primary keys")]
        [NUnit.Framework.TestCaseAttribute("LocalDb", "employee", "1", null)]
        [NUnit.Framework.TestCaseAttribute("MySql", "employee", "1", null)]
        [NUnit.Framework.TestCaseAttribute("PostgreSql", "employee", "1", null)]
        [NUnit.Framework.TestCaseAttribute("LocalDb", "workstation", "1", null)]
        [NUnit.Framework.TestCaseAttribute("MySql", "workstation", "1", null)]
        [NUnit.Framework.TestCaseAttribute("PostgreSql", "workstation", "1", null)]
        [NUnit.Framework.TestCaseAttribute("LocalDb", "building", "1", null)]
        [NUnit.Framework.TestCaseAttribute("MySql", "building", "1", null)]
        [NUnit.Framework.TestCaseAttribute("SqLite", "building", "1", null)]
        [NUnit.Framework.TestCaseAttribute("PostgreSql", "building", "1", null)]
        public virtual void DeleteByPrimaryKeys(string databaseType, string entityType, string entityCount, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete by primary keys", exampleTags);
#line 68
this.ScenarioSetup(scenarioInfo);
#line 69
 testRunner.Given(string.Format("I have initialized a {0} database", databaseType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 70
 testRunner.When(string.Format("I insert {0} {1} entities", entityCount, entityType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
 testRunner.And("I clear all the inserted entities", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
 testRunner.And(string.Format("I insert {0} {1} entities", entityCount, entityType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
 testRunner.And(string.Format("I delete all the inserted {0} entities", entityType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
 testRunner.And(string.Format("I query for all the {0} entities", entityType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
 testRunner.Then(string.Format("I should have {0} {1} entities in the database", entityCount, entityType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion