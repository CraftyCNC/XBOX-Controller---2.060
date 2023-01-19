Installation (version 2 and up):

Extract all files from the zip archive.

Place these 2 files into the directory c:\UCCNC\plugins\ (change as appropriate for your install directory)
xboxcontroller.dll (plugin) 
xboxcontroller.xml (default settings file) - NOTE, if you are updating, keep your old XML file or you will lose what you have setup already.  On the first run, the plugin will complain on loading that 'control not found', accept all messages, and after loading, fill in any missing new settings and hit save to update your XML file.

You must also  install the SlimDX runtime library (either X86 OR x64).  Select version of slimDX as appropriate for your operating system being 32 bit or 64 bit.  Look in the \slimdx\x86 or the \slimdx\x64 folder for the appropriate installer for the run time.  Note:  If you have previously installed either the SlimDX SDK, or the runtime and used the prior versions of the plugin, you will not need to reinstall slimdx runtime again (if just replace/upgrade only the xboxcontroller plugin dll).


Enable the plugin in UCCNC plugin settings.  You no longer need to enable the plugin on load w/ UCCNC.  THe pluguin as of 2.050 may not be loaded and closed using a user assigned button code (accessed by the config button in UCCNC plugin settings window). You may also allow the plugin to load w/ UCCNC, and it can be set to auto-minimize and auto-enable on load.



INSTALLATION TROUBLE SHOOTING NOTES:
1) If you cannot find the plugin to enable it in UCCNC 'configure plugins', that means that you have the xboxcontroller.dll file in the wrong location (should be in [UCCNC\plugins\] folder, or SlimDx isn't found correctly.  Please install the SlimDX runtime, or if that fails try the SDK, link to SDK is found on my website.


2)  If the plugin is found in the plugin configure window, and loading once enabled, but you see 'loop error' in the status bar and no response to the controller, check the following:
	a)  Likely missing correct version of DirectX (need xinput 1.3 installed), please install the SlimDX SDK to get it installed on your computer.  Reboot and try again.  If still having issue, check b!
	b)  Ensure that you are selecting both checkboxes 'enable' and 'call startup' in the UCCNC plugin configure window.  The XBox plugin MUST load w/ UCCNC, you can not use 'show' button to load the plugin after UCCNC is loaded. 




V2.0600:
8/1/2021
Settings update:

- The plugin now saves it's settings relative to the active profile.  You can have different settings for loading different profiles.  Settings are still saved in plugin folder, but the setttings will now be saved as file:  xboxcontroller_PROFILENAME.xml.    the plugin will still load your old/existing xboxcontroller.xml file, just hit save after loading first time to have it save w/ the profile name.


V2.0500:
12/20/2020
Usability and Interface Enhancements:

- Plugin can be started using user assignable button code (use config form to set)
- Plugin can be stopped/restareted and the xbox controller will be found.  Plugin no longer needs to be started w/ UCCNC, can now be loaded after the fact, using button or hotkey if desired.
- Plugin can load direct to minimized state, and auto enable.  Once setup, you never need to see the configuration form again.
- User can disable popup messages/warnings
- Option added to automatically enable jogging during load of plugin
- Added option to add 'safety' to the Jog Step selector.  If checked, pulling either of the two triggers is required to allow you to select the Jog Step value using right stick when assigned)
- Upon step selection with right stick, plugin will show the newly set step value in the notification tray area, when option to show is selected
- The DPad and Shoulder buttons can now be assigned to any axis for step-jog function.  
- Bug fixes and cleanup within plugin





V2.020:
1/14/2020
Bug Fixes - Thanks Trendsetter on UCCNC forum for catching some issues!

Made max velocity limits separate for each axis of each stick (was one velocity limit per stick)
Made max velocity limits optional, unchecking box reverts axis to be 0-100 % of axis velocity.  checking box makes axis 0 to max velocity set.
Added error checking to ensure that an axis is never commanded at > 100% of its velocity
Made each stick independantly able to do 'mixed' axis jogging
Some cleanup of step jog buttons to ensure that plugin always sets stepjog or continuousjog mode back to what it was prior to firing a step jog event.




V2.010:
1/12/2020
Added Status bar showing controller connection status, and status of plugin loop running
Added ability to customize the DPad and shoulder buttons.  If you customize and you want to set each button to jog an axis, you NEED to set both the axis-on button with the down-press, and you need to set the axis-stop button with the up-press, or you will get a run away jog.  In addition, cutom axes set on Dpad or shoulders will do either continuous or step, depending on what mode of jogging is set in UCCNC (ie, not locked into JUST step only).



V2.000:
12/31/2019
Re-Written using UC100 API for stick velocity controls (no longer feeds through screenset commands/buttons).
Added deadbands, ability to set maximum velocity on each stick, Ability to disable sticks independantly
Added Ability to have combined velocity for each stick (ie, x & y driven simultaneously at independant velocities).
Added Taskbar notification ICON, can enable/disable jog by doubleclicking on Icon.
Plugin can now be hidden to taskbar notification ICON (form and taskbar hide).  Bring back by right-clicking on the notification icon and using 'show plugin' from menu.





===================================
OLD VERSIONS:



Installation (version 1):

Place these 2 files into the directory x:\UCCNC\plugins\
xboxcontroller-1.xxxx.dll (plugin) 
xboxcontroller.xml (default settings file)
 
Download and install the SlimDX runtime library (version for .Net 2.0) from:
https://slimdx.org/download.php
Install x64 version for latest versions of UCCNC with 'anycpu' compiling of c#.


If you can't find the plugin in UCCNC 'config plugins' to enable it, SlimDX likely isn't installed correctly!


The plugin window must remain open to function (minimized out of the way) currently.



V1.0003:  Implemented triggers as safties, misc fixes.
V1.0004:  Fixed jogging with keyboard/flyout buttons when trigger set as safety and not pressed.


==============================


V1.0010: 
5/20/18	Recompiled as Net4 app (x86) to get to work with version 2104 of UCCNC.
Recompiled as ANYCPU, worked with x64 version,

had to install the x64 versions of both SlimDX runtime and slimDX SDK

Changes to stick settings to remove 'diagnal' velocity calculations, changes to make smoother at initial movement.

V1.0011: 
2/27/2019	
Added ability to select 'reversed' directions for Stick movements and DPad stepping.


V1.0015: 
4/27/2019	
Fixed occasional 'hang on start' with a message box about default feedrate
Vibration feedback moved to new threads (improve performance)


