Feature: Adding Seller Profile details
	Login to the website
	Seller can see the homepage to add profile details
	Seller can add profile and able to save

@Add language 
Scenario: Add Language known by seller
	Given Select Langauge and Click Add new
	When Seller have entered Language and level
 	Then Pop up will show Language has been added
	
@Edit language
Scenario:Edit Language
	Given Click Edit button
	When Seller have updated Language and level
 	Then Pop up will show Language has been updated
	
@Delete Language
Scenario: Delete Language
 Given Click delete button
 Then Pop up will show deleted

 @Add Education
 Scenario: Add Education done by seller
  Given Clicked Education in home page and pressed add new
  When Entered education details and pressed add
  Then Pop will show Education has been added

  @Edit Skill
  Scenario: Edit Skill entered by seller
  Given Clicked Skill and pressed edit button
  When Seller updated skill and level
  Then Pop up will show Skill has been added


