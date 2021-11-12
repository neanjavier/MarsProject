Feature: ProfilePageFeature
	As Mars Portal Admin
	I would like to add, update and delete Languages, Skills, Education and Certifications
	So I can manage employees time and material records successfully
	
@addlanguagetest @regression
Scenario: add language record with valid details
	Given I have logged into mars portal successfully
	And I have navigated to the profile page
	When I add language record
	Then the result should be created successfully

@updatelanguagetest @regression
Scenario Outline: update language record with valid details
	Given I have logged into mars portal successfully
	And I have navigated to the profile page
	When I update '<Language>' and '<LanguageLevel>' on an existing language record
	Then the result should have the updated '<Language>' and '<LanguageLevel>'

@deletelanguagetest @regression
Scenario Outline: update language record with valid details
	Given I have logged into mars portal successfully
	And I have navigated to the profile page
	When I update '<Language>' and '<LanguageLevel>' on an existing language record
	Then the result should have the updated '<Language>' and '<LanguageLevel>'

@addskillstest @regression
Scenario: add skill record with valid details
	Given I have logged into mars portal successfully
	And I have navigated to the profile page
	When I add skill record
	Then the result should be created successfully

@updateskilltest @regression
Scenario Outline: update skill record with valid details
	Given I have logged into mars portal successfully
	And I have navigated to the profile page
	When I update '<Skill>' and '<SkillLevel>' on an existing skills record
	Then the result should have the updated '<Skill>' and '<SkillLevel>'

@deletelanguagetest @regression
Scenario Outline: update language record with valid details
	Given I have logged into mars portal successfully
	And I have navigated to the profile page
	When I update '<Skill>' and '<SkillLevel>' on an existing time and material record
	Then the result should have the updated '<Skill>' and '<SkillLevel>'

@addeducationstest @regression
Scenario: add education record with valid details
	Given I have logged into mars portal successfully
	And I have navigated to the profile page
	When I add education record
	Then the result should be created successfully

@updateeducationtest @regression
Scenario Outline: update education record with valid details
	Given I have logged into mars portal successfully
	And I have navigated to the profile page
	When I update '<Country>' and '<Uni>' and '<Title>' and '<Degree>' and '<GradYear>' on an existing education record
	Then the result should have the updated '<Country>' and '<Uni>' and '<Title>' and '<Degree>' and '<GradYear>'

@deleteeducationtest @regression
Scenario Outline: update language record with valid details
	Given I have logged into mars portal successfully
	And I have navigated to the profile page
	When I update '<Country>' and '<Uni>' and '<Title>' and '<Degree>' and '<GradYear>' on an existing education record
	Then the result should have the updated '<Country>' and '<Uni>' and '<Title>' and '<Degree>' and '<GradYear>'

@addcertificationstest @regression
Scenario: add certification record with valid details
	Given I have logged into mars portal successfully
	And I have navigated to the profile page
	When I add certification record
	Then the result should be created successfully

@updatecertificationtest @regression
Scenario Outline: update certification record with valid details
	Given I have logged into mars portal successfully
	And I have navigated to the profile page
	When I update '<Country>' and '<Uni>' and '<Title>' and '<Degree>' and '<GradYear>' on an existing certification record
	Then the result should have the updated '<Country>' and '<Uni>' and '<Title>' and '<Degree>' and '<GradYear>'

@deletecertificationtest @regression
Scenario Outline: update certification record with valid details
	Given I have logged into mars portal successfully
	And I have navigated to the profile page
	When I update '<Country>' and '<Uni>' and '<Title>' and '<Degree>' and '<GradYear>' on an existing certification record
	Then the result should have the updated '<Country>' and '<Uni>' and '<Title>' and '<Degree>' and '<GradYear>'

	Examples:
	| Language | LanguageLevel |
	| test_Nean_edited1 | T |
	| test_Nean_edited2 | M |