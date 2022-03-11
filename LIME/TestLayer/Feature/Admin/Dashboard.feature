Feature: Dashboard


Scenario: Open Admin Dashboard & validate General links
Given Navigate to Lime Home Page
When Admin is clicked on main menu
And Dashboard is selected
Then General menu can be minimised / maximised and text links and icons are correctly displayed 
| UserLink | FeturesLink | PermissionLink |
| Users    | Features    | Permissions    |

Scenario: Open Admin Dashboard & validate Admin links
Given Navigate to Lime Home Page
When Admin is clicked on main menu
And Dashboard is selected
Then Admin menu can be minimised/maximised/text links and icons are correctly displayed


