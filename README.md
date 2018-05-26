# PDMAddInDebugger
SOLIDWORKS PDM Professional AddIn Debugger Console
# Advantages
- You can write to the console
- You can multi-select files and folders in the explorer
- No need to debug your explorer.exe
# Download 
Download and compile project.
# Usage
- Copy binary file (exe file) from the bin/debug folder to your PDM add-in vs project's bin/debug folder.
- Add binary file pathname to your vs project's start with program in the debug folder (if you're using C#) or Build (if you're using VB.NET)
- Add the PDM vault's local path to start program: 
Example: C:\Projets\PDMAddInSample\PDMAddInSample\bin\debug\PDMAddInDebugger.exe "c:\PDMVault\"
