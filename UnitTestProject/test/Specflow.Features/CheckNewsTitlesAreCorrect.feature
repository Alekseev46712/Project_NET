Feature: CheckNewsTitlesAreCorrect
	In order to read the most relevant news 
	As a site user
	I want the main news that are displayed to be relevant for today

@Titles
Scenario: Check the title of main news at the top of the News page 
	Given the main page of the website is opened
	When I click on News tab 
	#And close "Sign-in" pop-up
	Then I see the main news at the top of the site is relevant for today

Scenario: Check the titles of secondary news below the top of the News page
	Given the main page of the website is opened
	When I click on News tab 
	#And close "Sign-in" pop-up
	Then I see the secondary news below the top of the site is relevant for today

Scenario: Check the titles of first article searched by Category link 
	Given the news page of the website is opened
	When I searched article by Category link  
	#And close "Sign-in" pop-up
	Then I see the first searched article equal expected one