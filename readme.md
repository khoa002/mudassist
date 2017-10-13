# Mud Assist 2.1.4
Mud Assist is a Botbase for [Rebornbuddy](http://rebornbuddy.com) that gives full control over your CRs.
It's similar to the Combat Assist Botbase, but gives much more control.

## ![](http://i.imgur.com/vh0KdNW.png "Discord channel")
![Join us](https://discord.gg/YmzsEGm)

## Some Screens
![Routine](http://i.imgur.com/2krPGex.png)
![Movement](http://i.imgur.com/hipkyAY.png)
![Hotkeys](http://i.imgur.com/sL8Jwhs.png)
![Misc](http://i.imgur.com/8tDxFf5.png)

## Features
- Pause/Unpause with Hotkey
- Optional Auto Sprint Out of Combat/In Instance/In Combat
- Initiate Attacks While Out of Combat (if Combat Routine Supports it)
- Heal While Out of Combat (if Combat Routine Supports)
- Move In Range of Target or Tank
- Optional Facing Target
- Enable/Disable Specific parts of the Combat Routine, such as Pre Combat Buff/Heal/Combat Buff/Combat
- Optional Tank Assist (Target Tank's Target)
- Persistent Settings and Linked to Character

## Installation
1. [Download Mud Assist](https://github.com/miracle091/mudassist/archive/master.zip)
2. Unzip into **`<RB Path>\BotBases\`**
3. Select `MudAssist` from the **BotBase Dropdown Menu** after starting **RB**

## Change Log
- `2.1.4`
  - Removed RB_CN flags cause is not needed anymore
- `2.1.3`
  - Re-enabled persistent settings
  - Replace internal overlay with the one that RB have integrated
  - Replace internal logging with the one that RB have integrated
  - Renamed most of the settings name
  - Removed Targeting tab and all things related, like settings
  - Removed all debug checks
  - Changed all colors for logs and overlay
- `2.1.2`
  - Fixed a bug that prevent UI to be updated correctly if the bot is not started
  - Fixed a bug that call auto sprint in instance even when outside an instance
  - Minor changes to some actions logic
- `2.1.1`
  - Added Char Info tab with auto refresh, i really want this to add it...so enjoy :P
  - New movements that support both ranged and melee classes
  - Incremented max range to follow a target from 12 to 14,5
  - Disabled by default the following options: sprint in combat, sprint in instance, auto move to target
  - Overlay message link to ff process more easy, this change is valid for CN users too
  - Fixed a bug that allow multiple Settings window to be opened at the same time
  - Minor changes to some actions logic
- `2.1.0`
  - Added new section for Auto Sprint under Misc tab on Settings form
  - Added Beta tag + Version for future unstable releases
  - Added "Hotkey" for hotkey related log items
  - Added the possibility to disable the Hotkeys individually, thanks to Freiheit
  - Added Auto Complete Quest option
  - Added more debug log items
  - Reworked Auto Sprint logic
  - Reworked Auto Accept/Complete Quests logic
  - Removed both Save buttons, the settings is now saved automatically when the Settings form close
  - Minor fixes
- `2.0.9`
  - Settings form not have anymore the focus (can be left open without problems)
  - Added initial logic for debug
  - Added Debug section and master checkbox on Settings form
  - Added "Debug" log item
  - Added more checks before use Flash Message
  - Renamed log item "Navigator" to just "Nav" 
  - Fixed a BIG problem with Auto Skip Cinematic, now should work
- `2.0.8`
  - Changed some UX of the settings form
  - Now all the items in the UI have a name related to "what do"
  - Replaced old icon with a new one
  - Removed the old icon
  - Removed a item related to debug navigation (log too)
- `2.0.7`
  - Changed (again) colors for log items
  - Re-added Quest auto accept
  - Re-added Auto skip cinematics
  - Fixed minor things here and there
- `2.0.6`
  - .NET Framework 4.6.1 minimum is now required (like RB)
  - Formatted the code, is more readable now
  - Added icon on Settings Form
  - Changed colors for log items
  - Navigation COULD work with CN version too, i can't test it atm
  - Re-added overlay
  - Removed temporarily Quest auto accept
  - Removed temporarily Auto skip cinematics
- `2.0.5`
  - Sprint all times
  - Navigation work for RB64-Beta
- `2.0.4`
  - Logging Enhancements For Settings
  - Check If Player Is Alive Before Running Root
- `2.0.3`
  - DarkKnight Tank Support
- `2.0.2`
  - Fix Issues With Facing Not Setting Properly
- `2.0.1`
  - Fix Combat Reach Issues For Melee Classes (Thanks **torfin**)
  - Fix Some Combat Checking Issues (Thanks **torfin**)
  - Fix Minor Combat Issue w/ **Being Tanked** Mode
- `2.0.0`
  - Swappable Combat Routines
  - Auto-Accept Quests
  - Auto-Talk to NPCs
  - Waypoint-Based Navigation
  - Separate Follow Range & Combat Range
  - Additional Movement Mode For "Follow"
  - Hotkey For Movement Mode Toggle
  - New Targeting Mode: Lowest HP Being Tanked
  - Use Pull Behavior When Attacking Out Of Combat
  - Enable / Disable Combat Routine Rest Behavior
  - Enable / Disable Combat Routine Pull Buff Behavior
  - Selectable Navigation Provider
  - Use Combat Behavior For Pulling If No Pull Behavior
  - Only Use Combat Behavior IN Combat Unless Pulling W/ It
  - Logic Fix: Target Enemy Over Follow Tank To Fix CR Issues
  - Don't Sprint Inside Instances
  - Allow Pull If Not In Party OR Player Is Tank
  - Don't Execute Pull Or Combat Behavior Outside Of Pull Range
  - Namespace Updates
  - Fix Issues When CR Doesn't Implement Behavior
  - Lots Of Refactoring
  - Fix Some Navigation Provider Issues
  - Tweak Issues W/ Routines
  - Fix Bot Navigation With Providers
  - Fix Pull Routine
  - Navigation Tweaks
  - Combat Fixes
  - UI Improvements
  - Better Default Settings
  - Adjust Tab Order
  - Follow Tweaks
  - Version Update
  - Status Bar / Separate Save Button
  - Fix Waypoints From Jumping Tanks
- `1.1.3`
  - Improved Tank Assist Code (Don't Start Combat Until Tank Does)
  - Improved Following Logic With Min/Max Range
  - Prevent Movement From Interrupting Casting
- `1.1.2`
  - Hotkeys For Add/Remove Target
  - Can Now Acquire & Follow Targets While Mounted
  - Additional Target Filter For "None"
  - Numerous Target Filter Fixes / Enhancement
  - Get FFXIV Process Before Flashing Message (thanks newb23)
  - Use GameSettingsManager.FaceTargetOnAction For Facing (thanks newb23)
  - Other Various Bug Tweaks / Fixes
- `1.1.1`
  - Minor bug fixes
- `1.1.0`
  - Add Facing/Movement
  - Target List Enhancements
  - UI Improvements / Flash Messages
- `1.0.6`
  - Targeting by Distance. Execute CR while moving.
- `1.0.5`
  - Allow list to function as Blacklist or Whitelist
- `1.0.4`
  - Fix null pointer on Empty Hotkeys
- `1.0.3`
  - Improved Targeting Mode / Hotkeys
- `1.0.2`
  - Null check on GetPartyTank to prevent Log spam when Tank not in group
- `1.0.1`
  - Fix for CR toggle
- `1.0.0`
  - Release

## Planned Updates
- Nothing at the moment...
- Have any better ideas? PM me or open a request on Github. Thanks!

## Original Source Code
[Original Source code](https://github.com/mudbuddy/mud/)