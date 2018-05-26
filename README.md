# PDMAddInDebugger
SOLIDWORKS PDM Professional AddIn Debugger Console
# Advantages
- You can write to the console.
- Multi-selection is enabled.
- No need to debug your explorer.exe or notepad.exe.
# Download 
Download and compile project.
# Usage
- Copy binary file (exe file) from the bin/debug folder to your PDM add-in vs project's bin/debug folder (optional).
- Add binary file pathname to your vs project's start with program in the debug tab (if you're using C#) or in the build tab (if you're using VB.NET).
- Add the PDM vault's local path to start program (Example provided below). (optional) 
Example: C:\Projets\PDMAddInSample\PDMAddInSample\bin\debug\PDMAddInDebugger.exe "c:\PDMVault\"
