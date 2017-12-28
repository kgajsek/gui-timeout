# GUI Timeout
Replacement for Windows 'timeout' command with GUI and confirm/cancel options.

# Requirements
.NET 4.0 Client Profile is needed to run a precompiled binary, available [here](https://s3-eu-west-1.amazonaws.com/cdn.cyberkiko.com/Download/Tools/GUI-Timeout-v0.1.zip). To compile the project, Visual Studio (Community or higher) is required.

# Usage
GUI Timeout will wait for a given number of seconds (displaying countdown timer), with a given message. 3rd and 4th parameters are captions for confirm and cancel buttons.
If timeout expires or user clicks confirm button, GUI Timeout exits with exit code 0. If user clicks cancel button, GUI Timeout exits with exit code 1.

Sample usage:

```
GUITimeout.exe 60 "Maintenance pending, please log out!" "OK" "Not now, I'm busy!"
if errorlevel 1 goto :cancel
echo Maintenance in progress...
:cancel
```
