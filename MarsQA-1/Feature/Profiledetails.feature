Feature: Adding Seller Profile details
	Login to the website
	Seller can see the homepage to add profile details
	Seller can add profile and able to save

@language
Scenario: Add Language known by seller
	Given Select Langauge and Click Add new
	And Seller have entered Language and level
 	When Seller pressed add
	Then the pop up shows language has been added
@Skill
Scenario:Add Skill of the seller
	Given Select Skill and Click add new
	And Seller have entered Skill and level
 	When Seller pressed add button
	Then the pop up shows skill has been added

