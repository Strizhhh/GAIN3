using NUnit.Framework;
using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace GAIN3
{
    [Binding]
    public class ExchangeRatesApiSteps
    {

        string desiredbasecurrency;
        string realbasecurrency;
        string allcurrencies;
        string returnedRate;
        IRestResponse response;
        IRestClient client;
        IRestRequest request;
        IDictionary output;

        [Given("The expected base currency is EUR")]
        public void SetDesiredCurrency()
        {
            desiredbasecurrency = "EUR";
        }


        [When("I request latest excange rates")]
        public void CallLatestRates()
        {
            client = new RestClient("https://api.exchangeratesapi.io/");
            request = new RestRequest("latest", Method.GET);
            response = client.Execute(request);
            var deserial = new JsonDeserializer();
            output = deserial.Deserialize<Dictionary<string, string>>(response);
        }


        [Then("The base currency of responce should be EUR")]
        public void ComparingBaseCurrency()
        {
            realbasecurrency = output["base"].ToString();
            Assert.That(realbasecurrency, Is.EqualTo(desiredbasecurrency), "Base currency is not correct");
        }

        [Then("Supported currency (.*) is present in the response")]
        public void CurrencyListCheck(string currency)
        {
            allcurrencies = output["rates"].ToString();
            Assert.That(allcurrencies.Contains(currency));
        }


        [When(@"I call for historical rate for (.*) from date (.*)")]
        public void WhenICallForHistoricalRateForFromDate(string Currency, string Date)
        {
            client = new RestClient("https://api.exchangeratesapi.io/");
            request = new RestRequest(Date + "?symbols=" + Currency, Method.GET);
            response = client.Execute(request);
            var deserial = new JsonDeserializer();
            output = deserial.Deserialize<Dictionary<string, string>>(response);
        }


        [Then(@"returned value is (.*)")]
        public void ThenReturnedValueIs(string historicalRate)
        {
            returnedRate = output["rates"].ToString();
            returnedRate = returnedRate.Remove(0, 7);
            returnedRate = returnedRate.TrimEnd('}');
            Assert.That(returnedRate, Is.EqualTo(historicalRate), "Returned rate doesn't match historical data");
        }


    }
}



