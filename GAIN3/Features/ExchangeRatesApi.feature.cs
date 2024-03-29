// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace GAIN3.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("exchangeRatesApi")]
    public partial class ExchangeRatesApiFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ExchangeRatesApi.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "exchangeRatesApi", "\tIn order to verify quality of API service\r\n\tAs a QA engineer\r\n\tI want to execute" +
                    " sanity test pack", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Verify base currency")]
        [NUnit.Framework.CategoryAttribute("test")]
        public virtual void VerifyBaseCurrency()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify base currency", null, new string[] {
                        "test"});
#line 7
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 testRunner.Given("The expected base currency is EUR", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When("I request latest excange rates", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then("The base currency of responce should be EUR", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify list of available currencies")]
        [NUnit.Framework.CategoryAttribute("test")]
        [NUnit.Framework.TestCaseAttribute("CAD", null)]
        [NUnit.Framework.TestCaseAttribute("HKD", null)]
        [NUnit.Framework.TestCaseAttribute("ISK", null)]
        [NUnit.Framework.TestCaseAttribute("PHP", null)]
        [NUnit.Framework.TestCaseAttribute("DKK", null)]
        [NUnit.Framework.TestCaseAttribute("HUF", null)]
        [NUnit.Framework.TestCaseAttribute("CZK", null)]
        [NUnit.Framework.TestCaseAttribute("AUD", null)]
        [NUnit.Framework.TestCaseAttribute("RON", null)]
        [NUnit.Framework.TestCaseAttribute("SEK", null)]
        [NUnit.Framework.TestCaseAttribute("IDR", null)]
        [NUnit.Framework.TestCaseAttribute("INR", null)]
        [NUnit.Framework.TestCaseAttribute("BRL", null)]
        [NUnit.Framework.TestCaseAttribute("RUB", null)]
        [NUnit.Framework.TestCaseAttribute("HRK", null)]
        [NUnit.Framework.TestCaseAttribute("JPY", null)]
        [NUnit.Framework.TestCaseAttribute("THB", null)]
        [NUnit.Framework.TestCaseAttribute("CHF", null)]
        [NUnit.Framework.TestCaseAttribute("SGD", null)]
        [NUnit.Framework.TestCaseAttribute("PLN", null)]
        [NUnit.Framework.TestCaseAttribute("BGN", null)]
        [NUnit.Framework.TestCaseAttribute("TRY", null)]
        [NUnit.Framework.TestCaseAttribute("CNY", null)]
        [NUnit.Framework.TestCaseAttribute("NOK", null)]
        [NUnit.Framework.TestCaseAttribute("NZD", null)]
        [NUnit.Framework.TestCaseAttribute("ZAR", null)]
        [NUnit.Framework.TestCaseAttribute("USD", null)]
        [NUnit.Framework.TestCaseAttribute("MXN", null)]
        [NUnit.Framework.TestCaseAttribute("ILS", null)]
        [NUnit.Framework.TestCaseAttribute("GBP", null)]
        [NUnit.Framework.TestCaseAttribute("KRW", null)]
        [NUnit.Framework.TestCaseAttribute("MYR", null)]
        public virtual void VerifyListOfAvailableCurrencies(string currency, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "test"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify list of available currencies", null, @__tags);
#line 13
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 14
 testRunner.Given("The expected base currency is EUR", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
 testRunner.When("I request latest excange rates", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.Then(string.Format("Supported currency {0} is present in the response", currency), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify historical rates for currencies")]
        [NUnit.Framework.CategoryAttribute("test")]
        [NUnit.Framework.TestCaseAttribute("GBP", "2019-09-10", "0.893", null)]
        [NUnit.Framework.TestCaseAttribute("CNY", "2018-09-10", "7.9413", null)]
        [NUnit.Framework.TestCaseAttribute("USD", "1999-01-04", "1.1789", null)]
        public virtual void VerifyHistoricalRatesForCurrencies(string currency, string date, string historicalRate, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "test"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify historical rates for currencies", null, @__tags);
#line 55
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 56
 testRunner.Given("The expected base currency is EUR", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 57
 testRunner.When(string.Format("I call for historical rate for {0} from date {1}", currency, date), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 58
 testRunner.Then(string.Format("returned value is {0}", historicalRate), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
