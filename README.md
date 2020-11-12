# Console debugger for SW PDM API addins
SOLIDWORKS PDM Professional Add-In Debugger. 
# Advantages
- You can use Console.WriteLine to the console.
- Multi-selection is enabled.
- No need to debug using explorer.exe or notepad.exe.
# Usage
- Download the compiled binaries from the release page.
- Right-click on the downloaded archive and click properties and click unblock.
- Add PDMAddInDebugger.exe (from bin/debug) pathname to your VS project's start with program in the debug tab (if you're using C#) or in the build tab (if you're using VB.NET).
- (optional) Add the PDM vault view local path as a command argument. 

Or
- Clone repo.
- Open sln file in VS.
- Restore packages and build
- Add PDMAddInDebugger.exe (from bin/debug) pathname to your VS project's start with program in the debug tab (if you're using C#) or in the build tab (if you're using VB.NET).
- (optional) Add the PDM vault view local path as a command argument. 
