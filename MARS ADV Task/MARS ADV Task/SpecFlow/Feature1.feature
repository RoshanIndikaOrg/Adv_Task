Feature: AdvTaskFeature

As a MARS QA Admin
I would like to manage profile (add Language, Skills, Education and certification details, description and review it)
I would like to Manage Listings, Manage requests, and manage notifications

@tag1
Scenario: [Add and review Profile location data into the profile details]
	Given [I log in to the MAR QA website successfully]
	When [I want to add Profile details]
	Then [The Profile Location data should be created successfully]

Scenario: [Add and review Language data into the profile details]
	Given [I log in to the MAR QA website successfully for add language]
	When [I want to add Language details]
	Then [The Language data should be created successfully]

Scenario: [Add and review Skills data in to the profile details]
	Given [I log in to the MAR QA website for add skills]
	When [I want to add Skillls details]
	Then [The skills records should be created successfully]

Scenario: [Add and review Education data in to the profile details]
	Given [I log in to the MAR QA website to add education details]
	When [I want to add the Education details]
	Then [The education records should be created successfully]

Scenario: [Add and review Certification data in to the profile details]
	Given [I log in to the MAR QA website to add Certification details]
	When [I want to add the Certification details]
	Then [The Certification records should be created successfully]

Scenario: [Add and review Description data in to the profile details]
	Given [I log in to the MAR QA website for add Description]
	When [I want to add Description details]
	Then [The description records should be created successfully]

Scenario: [Add Share skill data in the share skill page]
	Given [I log in to the MAR QA website to add Share skill data]
	When [I want to add the Share skill data]
	Then [The Share skill data records should be created successfully]

Scenario: [Edit and review the data in the Managelisting]
	Given [I log in to the MAR QA website to edit details in the managelistings]
	When [I want to edit the data in the managelistings]
	Then [The managelistings data should be edited successfully]

Scenario: [Delete the data in the Managelisting]
	Given [I log in to the MAR QA website to Delete details in the managelistings]
	When [I want to Delete the data in the managelistings]
	Then [The managelistings data should be Deleted successfully]