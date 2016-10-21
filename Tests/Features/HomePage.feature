@UI
Feature: HomePage
	In order to view information about Valtech
	As a User
	I want to be able to navigate to hompage and access Latest News, About us links

@homePage
Scenario: Verify Latest News link exists on Homepage 
	Given I am on Valtech Hompage
	Then Latest News link is displayed


Scenario Outline: Verify Navigation from HomePage to Cases,Services and Jobs
Given I am on Valtech Hompage
When I Navigate to <Link> page
Then User is navigated to <Link> Page

Examples: 
| Link     |
| Cases    |
| Services |
| Jobs     |

# This Test case will be part of Contact Feature
Scenario: Verify Number of offices on contact page
Given I am on Valtech Hompage
When I Click Globe Icon
Then User is navigated to Contact page and 30 offices are displayed 


