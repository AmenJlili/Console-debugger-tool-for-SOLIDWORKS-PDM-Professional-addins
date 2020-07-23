# PDMAddInDebugger
SOLIDWORKS PDM Professional AddIn Debugger Console
# Advantages
- You can write to the console.
- Multi-selection is enabled.
- No need to debug using explorer.exe or notepad.exe.
# Download 
Download and compile project.
# Usage
- (optional) Copy binary file (exe file) from the bin/debug folder to your PDM add-in VS project's bin/debug folder.
- Add binary file (from bin/debug) pathname to your VS project's start with program in the debug tab (if you're using C#) or in the build tab (if you're using VB.NET).
- (optional) Add the PDM vault's local path to start program:
- Example: C:\Projets\PDMAddInSample\PDMAddInSample\bin\debug\PDMAddInDebugger.exe "c:\PDMVault\"
