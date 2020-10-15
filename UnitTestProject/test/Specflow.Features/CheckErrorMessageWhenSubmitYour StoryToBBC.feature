Feature: CheckErrorMessageWhenSubmitYourStoryToBBC				
	In order to send your story, drawing, video, or question 
	As a user who wants to get feedback																		
	I want to be sure that I have provided all the necessary data for feedback

@ErrorMessageWhenSubmitYourStory
Scenario: Check error message when submit story with empty field "Tell us your story" 
	Given the Have Your Say page of the website is opened
	And the Tell us field is <Tell us>
	And the Name field is <Name>
	And the Email field is <Email>
	And the Contact field" is <Contact>
	And the Location field" is <Location>
	And checkbox Please don't publish my name is <Don't publish my name>
	And checkbox I am over 16 years old is <Over 16>
	And checkbox I accept the Terms of Service is <Terms of Service>
	When user click on "Submit" button under the "Story and Contact Info" form or press Enter
	Then under "Tell us your story" field appears the error message "can't be blank"

Scenario: Check error message when submit story with empty field "Name" 
    Given the Have Your Say page of the website is opened
	And the Tell us field is <Tell us>
	And the Name field is <Name>								
	And the Email field is <Email>
	And the Contact field" is <Contact>
	And the Location field" is <Location>
	And checkbox Please don't publish my name is <Don't publish my name>
	And checkbox I am over 16 years old is <Over 16>
	And checkbox I accept the Terms of Service is <Terms of Service>
	When user click on "Submit" button under the "Story and Contact Info" form or press Enter
	Then under "Name" field appears the error message "Name can't be blank"
	
Scenario: Check error message when submit story without click checkbox "I'm over 16 years old" 
	Given the Have Your Say page of the website is opened
	And the Tell us field is <Tell us>
	And the Name field is <Name>
	And the Email field is <Email>
	And the Contact field" is <Contact>
	And the Location field" is <Location>
	And checkbox Please don't publish my name is <Don't publish my name>
	And checkbox I am over 16 years old is <Over 16>
	And checkbox I accept the Terms of Service is <Terms of Service>
	When user click on "Submit" button under the "Story and Contact Info" form or press Enter
	Then under checkbox "I am over 16 years old" appears the error message "must be accepted"

	Examples: 
	| Tell us | Name | Email | Contact | Location | Don't publish my name | Over 16      |Terms of Service  |
	|         |  Li  | Email | 10      | China    | Accept                | Accept       | Accept           |                 
	|  Story  |      | Email | 10      | China    | Accept                | Accept       | Accept           |                 
	|  Story  |  Li  | Email | 10      | China    | Accept                | Don't Accept | Accept           |                 

