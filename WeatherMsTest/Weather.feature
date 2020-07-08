Feature: Weather
This feature is to test weather from various sources

@mytag
Scenario: Validate weather from NDTV with openweather API
	Given I Read weather from NDTV News Website
	When I Read Weather from openweather API	
	Then Weather should be within threshold range
