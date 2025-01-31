Feature: ManageListing

As a user, 
I would like to edit, update, view and delete Skills in the Manage Listings

Background: 
    Given User logs into Mars portal and navigate to manage listings tab successfully

Scenario:01 -View Manage Listings
    Given User Add a Share Skill"<AddJsonFilePath>"
    When User click to view listing
	Then user should be able to view

	 Examples:
     | AddJsonFilePath                                                                                        |
     |C:\Visual_studio_project\AdvancedTaskPART2\AdvancedtaskSpecflow\JsonData\AddShareSkill.json|


    
Scenario:02 -Edit Manage Listings
    Given User Add a Share Skill"<AddJsonFilePath>"
    When  User click on edit and update the "<UpdateJsonFilePath>" listing 
    Then  record should be updated successfully

    Examples:  
   | AddJsonFilePath                                                                                                    | UpdateJsonFilePath                                                                                                   |
   | C:\Visual_studio_project\AdvancedTaskPART2\AdvancedtaskSpecflow\JsonData\AddShareSkill.json  | C:\Visual_studio_project\AdvancedTaskPART2\AdvancedtaskSpecflow\JsonData\UpdateShareSkill.json |


Scenario:03 -Delete Manage Listings
	Given User Add a Share Skill"<AddJsonFilePath>"
	When User deletes the listing
	Then that record should be deleted successfully

	Examples:
    | AddJsonFilePath                                                                                                   |
    |C:\Visual_studio_project\AdvancedTaskPART2\AdvancedtaskSpecflow\JsonData\AddShareSkill.json | 


	
Scenario:04 - Toggle Enable or disable 
	Given User Add a Share Skill"<AddJsonFilePath>" 
    When User click to toggle service 
    Then Sevice should be activated
		
	Examples:
    | AddJsonFilePath                                                                                         |
    | C:\Visual_studio_project\AdvancedTaskPART2\AdvancedtaskSpecflow\JsonData\AddShareSkill.json|




	
