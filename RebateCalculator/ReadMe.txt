We need to build a calculator for our customers to calculate the yearly sales. 
At the start of every year sales rep discusses the sales with every retailer and plans their rebate if they meet the targets.
Calculations will be done by following rules, one or more rules can be applied for each retailer, and the option to build more rules.
1.	10% rebate if you sell x dollars of product1. 
2.	If you sell 100 KG of product1 then 10 KG of product1 cost will be rebated.
3.	8% rebate if you sell x dollars of product1 and y dollars of product2.
Task
Please implement the C# code that calculates the total rebate given to the retailer at the end of the year. 
The solution should support applying additional rules.
Rebate % on total sell of 1 product, 
Rebate on QTY of 1 product
rebate % on total od p1 cost + p2 cost
rules - can be 1 or more

Retailer			|	
id	|	FullName	|
1	|	vinay		|
2	|	goel		|

Products
id	|	name		|
1	|	X			|
2	|	Y			|
3	|	Z			|

Sales
Id			|	RetailerId	|	ProductId	|	Quantity	|	Cost		|	ToatlCost	|	Year		|
1			|	1			|	1			|	10			|	100			|	1000		|	2023		|
2			|	1			|	2			|	20			|	200			|	4000		|	2023		|
3			|	1			|	3			|	30			|	300			|	9000		|	2023		|
4			|	2			|	1			|	10			|	100			|	1000		|	2023		|
5			|	2			|	2			|	20			|	200			|	4000		|	2023		|
6			|	2			|	3			|	30			|	300			|	9000		|	2023		|

Rebate
Id		|	ProductId	|	TargetType	|	Target	|	Year
1		|	1			|	1(Quantity)	|	10		|	2023
2		|	2			|	1(Quantity)	|	10		|	2023
3		|	3			|	1(Quantity)	|	10		|	2023
4		|	1			|	2(Cost)		|	1000	|	2023
5		|	2			|	2(Cost)		|	1000	|	2023
6		|	3			|	2(Cost)		|	1000	|	2023

RebatePlan
RebateId|	PlanId
1		|	1
2		|	2
3		|	2
4		|	3
5		|	4
6		|	4

RetailerPlan(RebatePlan_retailer_mapping) 
Id	| RetailerId	| RebatePlanId	| Rebate %
1	|	1			|	1			| 10
2	|	1			|	2			| 8
3	|	2			|	3			| 10
4	|	2			|	4			| 8

RebateCalculator.cs

Get Retailer yearly sales
Id			|	RetailerId	|	ProductId	|	Quantity	|	Cost		|	ToatlCost	|	Year		|
1			|	1			|	1			|	10			|	100			|	1000		|	2023		|
2			|	1			|	2			|	20			|	200			|	4000		|	2023		|
3			|	1			|	3			|	30			|	300			|	9000		|	2023		|

GetRetailer rebate plans
Id	| RetailerId	| RebatePlanId	| Rebate %
1	|	1			|	1			| 10
2	|	1			|	2			| 8

Get RebatePlanDTO Using rebate mapping table
RebateId|	PlanId
1		|	1
2		|	2
3		|	2

Id		|	ProductId	|	TargetType	|	Target	|	Year	|	PlanId
1		|	1			|	1(Quantity)	|	10		|	2023	|	1

2		|	2			|	1(Quantity)	|	10		|	2023	|	2
3		|	3			|	1(Quantity)	|	10		|	2023	|	2

calculate rebate --> %, cost
Given retilerId, For each rebate plan, Join rebatedto on sales table and check for each rebate, are the targets achieved
RetailerId	| RebatePlanId	| Rebate %	| Target Achieved	| CalculatedRebate
	1			|	1			| 10		| Yes				| 100	
	1			|	2			| 8			| No				| 0