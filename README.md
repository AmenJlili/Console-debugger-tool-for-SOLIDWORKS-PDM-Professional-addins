# PDMAddInDebugger
SOLIDWORKS PDM Professional AddIn Debugger Console
# Download 
Download and compile project.
# Usage
- Copy binary file (exe file) from the bin/debug folder to your PDM add-in vs project's bin/debug folder. 
\Add binary file pathname to your vs project's start with program in the debug folder (if you're using C#) or Build (if you're using VB.NET)
- Add the PDM vault's local path to start program: 
 Example: C:\Projets\PDMAddInSample\PDMAddInSample\bin\debug\PDMAddInDebugger.exe "c:\PDMVault\"
