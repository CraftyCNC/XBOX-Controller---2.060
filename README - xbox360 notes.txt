Installation (version 2 and up):

Place these 2 files into the directory c:\UCCNC\plugins\ (change as appropriate for your install directory)
xboxcontroller.dll (plugin) 
xboxcontroller.xml (default settings file)

You must then install 1 copy (either X86 OR x64) of the SlimDX.dll file into the main UCCNC directory (c:\UCCNC\)
Select version of slimDX as appropriate for your operating system being 32 bit or 64 bit.

Note:  If you have previously installed either the SlimDX SDK, or the runtime and used the prior versions of the plugin, you likely will not need to install slimdx.dll into the UCCNC folder.  Alternateively, you may uninstall the SDK and/or the runtime and place just the slimdx.dll (X64 OR x86) into the UCCNC folder only.



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


