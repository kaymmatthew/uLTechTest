Feature: Verify user can successfully navigate to all subheadings in the bottom menu bar: ie Careers, Help and Support, Contact Centre.

Background:
	Given User is on ul.com home page
	And User click on accept all cookies
  
@mytag1
Scenario: Verify that user can successfully navigate to careers page
	When User click on working at UL Solutions linktext
	Then User is on Careers page with headerText

@mytag2
Scenario: Verify that user can successfully navigate to global job search page
	When User click on global job search linktext
	Then User is on global job search page with a pageHeaderText 'Welcome To Our Career Site (Global)'

@mytag3
Scenario: Verify that user can successfully navigate to US job search page
	When User click on US job search linktext
	Then User is on US job search page with a pageHeaderText 'Welcome To Our Career Site (United States) - Job Opportunities'

@mytag4
Scenario: Verify that user can successfully navigate to help center page
	When User click on help center linktext
	Then User is on Help and Support page with a pageHeaderText 'Help and Support'
	
@mytag5
Scenario: Verify that user can successfully navigate to Tools, Apps and Databases page
	When User click on Tools, Apps and Databases linktext
	Then User is on Tools Apps and Databases page with a pageHeaderText 'Tools, Apps and Databases'

@mytag6
Scenario: Verify that user can successfully navigate to report a concern page
	When User click on report a concern linktext
	Then User is on report a concern page, with a pageHeaderText 'Market Surveillance'

@mytag7
Scenario: Verify that user can successfully navigate to contact Us page
	When User click on contact Us linktext
	Then User is on contact Us page, with a pageHeaderText Let's start a conversation

@mytag8
Scenario: Verify that user can successfully navigate to Manage Your Subscriptions page
	When User click on Manage Your Subscriptions linktext
	Then User is on Manage Your Subscriptions page, with a pageHeaderText 'Communications Preferences'

@mytag9
Scenario: Verify that user can successfully navigate to Locations page
	When User click on Locations linktext
	Then User is on Locations page, with a pageHeaderText 'Locations'

@mytag10
Scenario: Verify that user can successfully view the image on the news page
	When User click on News btn
	Then User is presented with a particular image showing in the News section

@mytag11
Scenario: Verify that a user can successfully select Germany (Deutsch) from the selection under the Choose a region select box
	When User select Germany (Deutsch) from the selection under the Choose a region select box
	Then User is redirected to the UL Solutions Deutschland page 'UL SOLUTIONS DEUTSCHLAND'



#TestCases for UL SOLUTION Manual Tech Task
#@mytag1
#Scenario: Verify that user can successfully create a new task list 
	#Given User is on ulSolution dashboard page
	#When User click on create new task list button
	#And User enter a valid required details asper specification
	#	| Name | Email                 | PhoneNumber |
	#	| John | johnsmith@hotmail.com | 07889989876 |
	#And User click submit button
	#Then new task list is crteated and displayed.
	#And task Items conrtains the following attributes:
	#	| Id | Name | Email                 | PhoneNumber | description       | priority | complete flag |
	#	| 01 | John | johnsmith@hotmail.com | 07889989876 | Reading for exams | 1        | complete flag |

#@mytag2
#Scenario: Verify that user can successfully rename/modify their name on the task list page 
	#Given User is on ulSolution dashboard page
	#When User click on task list button
	#And User is on task list page
	#When User click on edith name
	#Then User should be able to edith name successfully

#@mytag3
#Scenario: Verify that user can successfully delete from the task list page 
	#Given User is on ulSolution dashboard page
	#When User click on task list button
	#And User is on task list page
	#When User click on delete button on one the created list of task
	#Then User should be able to delete task successfully

#@mytag4
#Scenario: Verify that user is unable to successfully create a task list with mandatory field email ommited 
	#Given User is on ulSolution dashboard page
	#When User click on create new task list button
	#And User enter a valid required details asper specification with email fields ommited
	#	| name | Email | PhoneNumber |
	#	| John |       | 07889989876 |
	#And An error message is presented to the user 'You must provide your email address'
 
#@mytag5
#Scenario: Verify that user is unable to successfully create a task list with mandatory field name ommited
#	Given User is on ulSolution dashboard page
#	When User click on create new task list button
#	And User enter a valid required details asper specification with name field ommited
#		| name | Email                 | PhoneNumber |
#		|      | johnsmith@hotmail.com | 07889989876 |
#	And An error message is presented to the user 'You must provide your name'

#@mytag6
#Scenario: Verify that user is unable to successfully create a task list with invalid email format
	#Given User is on ulSolution dashboard page
	#When User click on create new task list button
	#And User enter a valid required details asper specification with invalid email format
	#	| name | Email                | PhoneNumber |
	#	| John | johnsmith@hotmailcom | 07889989876 |
	#And An error message is presented to the user 'please, provide a valid email adress'
  	
#@mytag7
#Scenario: Verify that user is unable to successfully create a task list with invalid phoneNumber format
	#Given User is on ulSolution dashboard page
	#When User click on create new task list button
	#And User enter a valid required details asper specification with invalid phone number format
	#	| Name | Email                 | PhoneNumber     |
	#	| John | johnsmith@hotmail.com | 23407889989876  |
	#And An error message is presented to the user 'The number you entered is not a valid mobile number'

#@mytag8
#Scenario: Verify that user is unable to successfully create a task list with invalid name format
	#Given User is on ulSolution dashboard page
	#When User click on create new task list button
	#And User enter a valid required details asper specification with invalid name format
	#	| Name | Email                 | PhoneNumber |
	#	| J    | johnsmith@hotmail.com | 07889989876 |
	#And An error message is presented to the user 'Min. 3 Characters'
	#Note: Above is a character length check depending on the length specified by the requirement.
   	
#@mytag9
#Scenario: Verify that user is unable to successfully create a task list with blank fields
	#Given User is on ulSolution dashboard page
	#When User click on create new task list button
	#And User enter empty details in the mandeory fields
	#	| Name | Email | PhoneNumber |
	#	|      |       |             |
	#And An error message is presented to the user 'You must provide all the mandatory fields'
	#An error will be thrown at the buttom of all the mandatory fields prompting the user to enter required values.
	
#@mytag10
#Scenario: Verify that user is unable to successfully create a task list with blank fields
	#Given User is on ulSolution dashboard page
	#When User click on create new task list button
	#And User enter a valid required details asper specification with invalid name format
	#	| Name   | Email                 | PhoneNumber |
	#	| John01 | johnsmith@hotmail.com | 07889989876 |
	#And An error message is presented to the user 'No special characters or numerics are permitted'
     	
#@mytag11
#Scenario: Verify that user is unable to successfully create a task list with blank fields
	#Given User is on ulSolution dashboard page
	#When User click on create new task list button
	#And User enter a valid required details asper specification with invalid name format
	#	| Name | Email                 | PhoneNumber  |
	#	| John | johnsmith@hotmail.com | a07889989876 |
	#And An error message is presented to the user 'No special characters are permitted'

#@mytag12
#Scenario: Verify that user is unable to successfully create a task list with mandatory field phone number ommited
	#Given User is on ulSolution dashboard page
	#When User click on create new task list button
	#And User enter a valid required details asper specification with name field ommited
	#	| name | Email                 | PhoneNumber |
	#	| John | johnsmith@hotmail.com |             |
	#And An error message is presented to the user 'You must provide your phone number'
	#Note: The word MUST is used because it's a mandatory field
     
 #NOTE: The Submit button shouldn't be higlighted when the user has not eneter all required details into the mandatory 
 #fields.
 
 # With regards to the phone number as soon as user switch to type phone number into the number fields then alphabets shouldn't
 #be enabeled. 
