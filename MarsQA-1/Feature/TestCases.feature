Feature: Login to website and adding SellerProfile

@login 
Scenario: I login to website with invalid credential
	Given I login to website
	And I have entered invalid user name and password
	When I pressed Login button
	Then the login will be failed 

@Add Skill
Scenario: Add Skill known by seller
	Given Login to website and Select Skill 
	When Clicked Add new and Seller have entered Skill and level
 	And Seller press add 
	Then Pop up will show skill has been added
	
@Edit Skill
Scenario:Edit Skill
	Given Login to website and click skill
	When Clicked Edit button and Seller have updated Skill and level
	And Seller press update button
 	Then Pop up will show skill has been updated
	
@Delete Skill
Scenario: Delete Skill
 Given Login to website and select Skill
 When Click delete button
 Then It will be deleted
 
	@Add Education
Scenario: Add Education of seller
	Given Login to website and Select Education
	When  Click Add new and entered Eduction details
 	And Seller press add 
	Then Pop up will show Education has been added
@Edit Education
Scenario:Edit Education
	Given Login to website and click Education
	When Clicked Edit button and Seller have Update the Education detail
 	And Seller clicked update button
	Then Pop up will show Education has been updated
	
@Delete Education
Scenario: Delete Education
 Given Login to website and select education
 When Click delete button
 Then It will be deleted

 @Add Certification
Scenario: Add Certification of seller
	Given Login to website and Select Certification 
	When Click Add new and Seller have entered Certification details
 	And Seller press add 
	Then Pop up will show Certification has been added
@Edit Certification
Scenario:Edit Certification
	Given Login to website and Click Certification 
	When Clicked Edit button and Seller have Update the Certifiction detail
 	And Seller clicked update button
	Then Pop up will show Certification has been updated
	
@Delete Certification
Scenario: Delete Certification
 Given Login to website and certification
 When Click delete button
 Then It will be deleted
