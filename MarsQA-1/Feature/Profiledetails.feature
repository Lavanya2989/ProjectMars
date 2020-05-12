Feature: Adding Seller Profile details
	Login to the website
	Seller can see the homepage to add profile details
	Seller can add profile and able to save

@Add language 
Scenario: Add Language known by seller
	Given Select Langauge and Click Add new
	When Seller have entered Language and level
 	Then Seller pressed add
	
@Edit language
Scenario:Edit Language
	Given Click Edit button
	When Seller have updated Language and level
 	Then Seller clicked update button
	
@Delete Language
Scenario: Delete Language
 Given Click delete button
 


