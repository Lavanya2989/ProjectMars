Feature: Login to website and adding SellerProfile

@login
Scenario: I login to website with invalid credential
	Given I login to website
	And I have entered invalid user name and password
	When I pressed Login button
	Then the login was failed 

@Add Skill
Scenario: Add Skill known by seller
	Given Select Skill and Click Add new
	When Seller have entered Skill and level
 	And Seller press add 
	Then Pop shows skill has been added
	
@Edit Skill
Scenario:Edit Skill
	Given Click Edit button
	When Seller have updated Skill and level
	And Seller press update button
 	Then Pop up shows skill has been updated
	
@Delete Skill
Scenario: Delete Skill
 Given Click delete button
 
	@Add Education
Scenario: Add Education of seller
	Given Select Education and Click Add new
	When Seller have entered Eduction details
 	And Seller press add 
	Then Pop shows Education has been added
@Edit Education
Scenario:Edit Language
	Given Clicked Edit button
	When Seller have Update the Education detail
 	And Seller clicked update button
	Then Pop up shows Education has been updated
	
@Delete Education
Scenario: Delete Education
 Given Click delete button

 @Add Certification
Scenario: Add Certification of seller
	Given Select Certification and Click Add new
	When Seller have entered Certification details
 	And Seller press add 
	Then Pop shows Certification has been added
@Edit Certification
Scenario:Edit Language
	Given Clicked Edit button
	When Seller have Update the Certifiction detail
 	And Seller clicked update button
	Then Pop up shows Certification has been updated
	
@Delete Education
Scenario: Delete Education
 Given Click delete button
