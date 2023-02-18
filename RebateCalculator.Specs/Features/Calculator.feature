Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for calculating rebate


@retailerSales
Scenario Outline: Get Retailer Yearly Sales
	Given retailer id <retailerId>
	When calculaterebate by retailerId method is called
	Then the retailer details <retailerRebateDetails> should be returned

	Examples:
		| retailerId | retailerRebateDetails				|
		| 1          | 1,1,10,True,100,1,2,8,False,0		|
		| 2			 | 2,3,10,True,100,2,4,8,True,1040		|