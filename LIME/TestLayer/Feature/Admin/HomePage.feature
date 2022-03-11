Feature: HomePage
	Simple calculator for adding two numbers

Scenario: Select language Cymraeg (Welsh)
Given Navigate to Lime Home Page
When Language flag is clicked
And select the < Cymraeg > language
Then The flag icon changes to the Welsh flag

Scenario: Select language English GB
Given Navigate to Lime Home Page
When Language flag is clicked
And English GB is selected
Then The flag icon changes to the English flag

Scenario: Select language English US
Given Navigate to Lime Home Page
When Language flag is clicked
And English US is selected
Then The flag icon changes to the American flag

Scenario: Select language Espanol
Given Navigate to Lime Home Page
When Language flag is clicked
And Espanol is selected
Then The flag icon changes to the Spanish flag

Scenario: Select language Mandarin
Given Navigate to Lime Home Page
When Language flag is clicked
And Mandarin is selected
Then The flag icon changes to the Taiwan flag

Scenario: Open notification
Given Navigate to Lime Home Page
When Notifications icon is clicked
And View All is clicked
Then Validate that page header is Notifications Notifications

Scenario: Validate the edit profile header
Given Navigate to Lime Home Page
When Profile icon is clicked 
And : Edit Profile is clicked
Then Header text on page is 'Edit Profile'






