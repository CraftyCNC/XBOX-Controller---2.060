
XBox controller Plugin is compiled as ANYCPU, and references the x64 version of slimDX.  It will run on either X86 or X64 as it is.

But, end user must install correct version of SlimDX.DLL (either X86 or x64) to install into c:\UCCNC\ (main UCCNC folder, adjust as necessary):

notes:
On X64 windows 10 computer:
Built this way, it will run with the x64 slimdx.dll installed into UCCNC folder.  Will NOT run with x86 slimdx.dll installed in UCCNC folder.

On X86 windows 7 computer:
Will NOT run w/ x64 slimdx.dll installed in UCCNC. Will run w/ x86 slimdx.dll installed into UCCNC folder.



