Feature: ubuntu setup prod1
#Regression Type
#Correct Values = true
#Incorrect Values = false
#Illegal Values = false
#Invalid Values = false
#Boundary Values = false
#Edge Cases Values = false

@Verify_login_with_valid_credentials
@uid924592891
@set21
@test001
@Id697821635fbefd33669444ce
Scenario Outline: Verify login with valid credentials
	Given I have access to application
	When I clicked Books in demo web shop
	Then verify displayed Books in demo web shop
	And verify displayed Computers in demo web shop
	When I clicked Computers in demo web shop
	Then verify displayed Computers in demo web shop
	When I clicked Electronics in demo web shop
	Then verify displayed Electronics in demo web shop
	When I clicked Apparel Shoes in demo web shop
	Then verify displayed Apparel Shoes in demo web shop
	When I clicked Apparel Shoes in demo web shop
	Then verify displayed Apparel Shoes in demo web shop
	When I clicked Digital downloads in demo web shop
	Then verify displayed Digital downloads in demo web shop
	When I clicked Jewelry in demo web shop
	Then verify displayed Jewelry in demo web shop
	When I clicked Gift Cards in demo web shop
	Then verify displayed Gift Cards in demo web shop
	And '<page>' is displayed with '<content>'

Examples:
	| SlNo. | page          | content |
	|     1 | Demo Web Shop | NA      |

#Total No. of Test Cases : 1

@Verify_error_with_invalid_username
@uid924592891
@set21
@test002
@Id697821635fbefd33669444cf
Scenario Outline: Verify error with invalid username
	Given I have access to application
	When I clicked Books in demo web shop
	Then verify displayed Books in demo web shop
	And verify displayed Computers in demo web shop
	When I clicked Computers in demo web shop
	Then verify displayed Computers in demo web shop
	When I clicked Electronics in demo web shop
	Then verify displayed Electronics in demo web shop
	When I clicked Apparel Shoes in demo web shop
	Then verify displayed Apparel Shoes in demo web shop
	When I clicked Apparel Shoes in demo web shop
	Then verify displayed Apparel Shoes in demo web shop
	When I clicked Digital downloads in demo web shop
	Then verify displayed Digital downloads in demo web shop
	When I clicked Jewelry in demo web shop
	Then verify displayed Jewelry in demo web shop
	When I clicked Gift Cards in demo web shop
	Then verify displayed Gift Cards in demo web shop
	And '<page>' is displayed with '<content>'

Examples:
	| SlNo. | page          | content |
	|     1 | Demo Web Shop | NA      |

#Total No. of Test Cases : 2

@Verify_error_with_invalid_password
@uid924592891
@set21
@test003
@Id697821635fbefd33669444d0
Scenario Outline: Verify error with invalid password
	Given I have access to application
	When I clicked Books in demo web shop
	Then verify displayed Books in demo web shop
	And verify displayed Computers in demo web shop
	When I clicked Computers in demo web shop
	Then verify displayed Computers in demo web shop
	When I clicked Electronics in demo web shop
	Then verify displayed Electronics in demo web shop
	When I clicked Apparel Shoes in demo web shop
	Then verify displayed Apparel Shoes in demo web shop
	When I clicked Apparel Shoes in demo web shop
	Then verify displayed Apparel Shoes in demo web shop
	When I clicked Digital downloads in demo web shop
	Then verify displayed Digital downloads in demo web shop
	When I clicked Jewelry in demo web shop
	Then verify displayed Jewelry in demo web shop
	When I clicked Gift Cards in demo web shop
	Then verify displayed Gift Cards in demo web shop
	And '<page>' is displayed with '<content>'

Examples:
	| SlNo. | page          | content |
	|     1 | Demo Web Shop | NA      |

#Total No. of Test Cases : 3

@Verify_login_with_blank_username_and_password
@uid924592891
@set21
@test004
@Id697821635fbefd33669444d1
Scenario Outline: Verify login with blank username and password
	Given I have access to application
	When I clicked Books in demo web shop
	Then verify displayed Books in demo web shop
	And verify displayed Computers in demo web shop
	When I clicked Computers in demo web shop
	Then verify displayed Computers in demo web shop
	When I clicked Electronics in demo web shop
	Then verify displayed Electronics in demo web shop
	When I clicked Apparel Shoes in demo web shop
	Then verify displayed Apparel Shoes in demo web shop
	When I clicked Apparel Shoes in demo web shop
	Then verify displayed Apparel Shoes in demo web shop
	When I clicked Digital downloads in demo web shop
	Then verify displayed Digital downloads in demo web shop
	When I clicked Jewelry in demo web shop
	Then verify displayed Jewelry in demo web shop
	When I clicked Gift Cards in demo web shop
	Then verify displayed Gift Cards in demo web shop
	And '<page>' is displayed with '<content>'

Examples:
	| SlNo. | page          | content |
	|     1 | Demo Web Shop | NA      |

#Total No. of Test Cases : 4

@Verify_password_masking
@uid924592891
@set21
@test005
@Id697821635fbefd33669444d2
Scenario Outline: Verify password masking
	Given I have access to application
	When I clicked Books in demo web shop
	Then verify displayed Books in demo web shop
	And verify displayed Computers in demo web shop
	When I clicked Computers in demo web shop
	Then verify displayed Computers in demo web shop
	When I clicked Electronics in demo web shop
	Then verify displayed Electronics in demo web shop
	When I clicked Apparel Shoes in demo web shop
	Then verify displayed Apparel Shoes in demo web shop
	When I clicked Apparel Shoes in demo web shop
	Then verify displayed Apparel Shoes in demo web shop
	When I clicked Digital downloads in demo web shop
	Then verify displayed Digital downloads in demo web shop
	When I clicked Jewelry in demo web shop
	Then verify displayed Jewelry in demo web shop
	When I clicked Gift Cards in demo web shop
	Then verify displayed Gift Cards in demo web shop
	And '<page>' is displayed with '<content>'

Examples:
	| SlNo. | page          | content |
	|     1 | Demo Web Shop | NA      |

#Total No. of Test Cases : 5

@Verify_Show_Password_functionality
@uid924592891
@set21
@test006
@Id697821635fbefd33669444d3
Scenario Outline: Verify Show Password functionality
	Given I have access to application
	When I clicked Books in demo web shop
	Then verify displayed Books in demo web shop
	And verify displayed Computers in demo web shop
	When I clicked Computers in demo web shop
	Then verify displayed Computers in demo web shop
	When I clicked Electronics in demo web shop
	Then verify displayed Electronics in demo web shop
	When I clicked Apparel Shoes in demo web shop
	Then verify displayed Apparel Shoes in demo web shop
	When I clicked Apparel Shoes in demo web shop
	Then verify displayed Apparel Shoes in demo web shop
	When I clicked Digital downloads in demo web shop
	Then verify displayed Digital downloads in demo web shop
	When I clicked Jewelry in demo web shop
	Then verify displayed Jewelry in demo web shop
	When I clicked Gift Cards in demo web shop
	Then verify displayed Gift Cards in demo web shop
	And '<page>' is displayed with '<content>'

Examples:
	| SlNo. | page          | content |
	|     1 | Demo Web Shop | NA      |

#Total No. of Test Cases : 6

@Verify_login_button_is_disabled_until_credentials_entered
@uid924592891
@set21
@test007
@Id697821635fbefd33669444d4
Scenario Outline: Verify login button is disabled until credentials entered
	Given I have access to application
	When I clicked Books in demo web shop
	Then verify displayed Books in demo web shop
	And verify displayed Computers in demo web shop
	When I clicked Computers in demo web shop
	Then verify displayed Computers in demo web shop
	When I clicked Electronics in demo web shop
	Then verify displayed Electronics in demo web shop
	When I clicked Apparel Shoes in demo web shop
	Then verify displayed Apparel Shoes in demo web shop
	When I clicked Apparel Shoes in demo web shop
	Then verify displayed Apparel Shoes in demo web shop
	When I clicked Digital downloads in demo web shop
	Then verify displayed Digital downloads in demo web shop
	When I clicked Jewelry in demo web shop
	Then verify displayed Jewelry in demo web shop
	When I clicked Gift Cards in demo web shop
	Then verify displayed Gift Cards in demo web shop
	And '<page>' is displayed with '<content>'

Examples:
	| SlNo. | page          | content |
	|     1 | Demo Web Shop | NA      |

#Total No. of Test Cases : 7

@Verify_user_redirection_after_logout
@uid924592891
@set21
@test008
@Id697821635fbefd33669444d5
Scenario Outline: Verify user redirection after logout
	Given I have access to application
	When I clicked Books in demo web shop
	Then verify displayed Books in demo web shop
	And verify displayed Computers in demo web shop
	When I clicked Computers in demo web shop
	Then verify displayed Computers in demo web shop
	When I clicked Electronics in demo web shop
	Then verify displayed Electronics in demo web shop
	When I clicked Apparel Shoes in demo web shop
	Then verify displayed Apparel Shoes in demo web shop
	When I clicked Apparel Shoes in demo web shop
	Then verify displayed Apparel Shoes in demo web shop
	When I clicked Digital downloads in demo web shop
	Then verify displayed Digital downloads in demo web shop
	When I clicked Jewelry in demo web shop
	Then verify displayed Jewelry in demo web shop
	When I clicked Gift Cards in demo web shop
	Then verify displayed Gift Cards in demo web shop
	And '<page>' is displayed with '<content>'

Examples:
	| SlNo. | page          | content |
	|     1 | Demo Web Shop | NA      |

#Total No. of Test Cases : 8

@Verify_case_sensitivity_in_login_credentials
@uid924592891
@set21
@test009
@Id697821635fbefd33669444d6
Scenario Outline: Verify case sensitivity in login credentials
	Given I have access to application
	When I clicked Books in demo web shop
	Then verify displayed Books in demo web shop
	And verify displayed Computers in demo web shop
	When I clicked Computers in demo web shop
	Then verify displayed Computers in demo web shop
	When I clicked Electronics in demo web shop
	Then verify displayed Electronics in demo web shop
	When I clicked Apparel Shoes in demo web shop
	Then verify displayed Apparel Shoes in demo web shop
	When I clicked Apparel Shoes in demo web shop
	Then verify displayed Apparel Shoes in demo web shop
	When I clicked Digital downloads in demo web shop
	Then verify displayed Digital downloads in demo web shop
	When I clicked Jewelry in demo web shop
	Then verify displayed Jewelry in demo web shop
	When I clicked Gift Cards in demo web shop
	Then verify displayed Gift Cards in demo web shop
	And '<page>' is displayed with '<content>'

Examples:
	| SlNo. | page          | content |
	|     1 | Demo Web Shop | NA      |

#Total No. of Test Cases : 9

@Verify_Remember_Me_checkbox_functionality
@uid924592891
@set21
@test010
@Id697821635fbefd33669444d7
Scenario Outline: Verify Remember Me checkbox functionality
	Given I have access to application
	When I clicked Books in demo web shop
	Then verify displayed Books in demo web shop
	And verify displayed Computers in demo web shop
	When I clicked Computers in demo web shop
	Then verify displayed Computers in demo web shop
	When I clicked Electronics in demo web shop
	Then verify displayed Electronics in demo web shop
	When I clicked Apparel Shoes in demo web shop
	Then verify displayed Apparel Shoes in demo web shop
	When I clicked Apparel Shoes in demo web shop
	Then verify displayed Apparel Shoes in demo web shop
	When I clicked Digital downloads in demo web shop
	Then verify displayed Digital downloads in demo web shop
	When I clicked Jewelry in demo web shop
	Then verify displayed Jewelry in demo web shop
	When I clicked Gift Cards in demo web shop
	Then verify displayed Gift Cards in demo web shop
	And '<page>' is displayed with '<content>'

Examples:
	| SlNo. | page          | content |
	|     1 | Demo Web Shop | NA      |

#Total No. of Test Cases : 10

