Feature: basic

A short summary of the feature

Scenario Outline: basic file check
Given I login to vanquis app
And I provide the username '<username>' and password '<password>'
When I click on the login button
Then I redirect to Home page
Examples: 
| username       | password |
| test@gmail.com | password |

Scenario: test table
Given I redirect to Login Url
When I enter username and password 
| username  | password  |
| username1 | password1 |
Then I redirect to Home page
