Feature: exchangeRatesApi
	In order to verify quality of API service
	As a QA engineer
	I want to execute sanity test pack

@test
Scenario: Verify base currency
	Given The expected base currency is EUR
	When I request latest excange rates
	Then The base currency of responce should be EUR

@test
Scenario Outline: Verify list of available currencies
	Given The expected base currency is EUR
	When I request latest excange rates
	Then Supported currency <Currency> is present in the response

	Examples:
	| Currency |
	| CAD      |
	| HKD      |
	| ISK      |
	| PHP      |
	| DKK      |
	| HUF      |
	| CZK      |
	| AUD      |
	| RON      |
	| SEK      |
	| IDR      |
	| INR      |
	| BRL      |
	| RUB      |
	| HRK      |
	| JPY      |
	| THB      |
	| CHF      |
	| SGD      |
	| PLN      |
	| BGN      |
	| TRY      |
	| CNY      |
	| NOK      |
	| NZD      |
	| ZAR      |
	| USD      |
	| MXN      |
	| ILS      |
	| GBP      |
	| KRW      |
	| MYR      |
	

@test
Scenario Outline: Verify historical rates for currencies
	Given The expected base currency is EUR
	When I call for historical rate for <Currency> from date <Date>
	Then returned value is <historicalRate>

	Examples:
	| Currency | Date       | historicalRate |
	|	 GBP   | 2019-09-10 |    0.893       |
	|	 CNY   | 2018-09-10 |    7.9413      |
	|	 USD   | 1999-01-04 |    1.1789      |