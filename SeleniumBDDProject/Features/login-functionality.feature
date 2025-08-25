Feature: User Login Functionality

@test001
Scenario Outline: User logs in to the application
    Given I have access to the application
    When I enter username as '<username>'
    And I enter password as '<password>'
    And I click the login button

Examples:
| username    | password  |
| testuser    | testpass  |
