## ASCOM.Core

This is an experimental port of several ASCOM .Net libraries for driver development. Because this includes WinForms and COM Objects it is only for the Windows platform. Both ASCOM.Utilities and ASCOM.DriverAccess should contain effectively identical functions to the main platform. Together they should allow both the creation of .Net Core COM based drivers and allow .Net Core apps to load existing ASCOM drivers. You can see a sample .Net Core local server here: https://github.com/DanielVanNoord/TelescopeSimulator-Core. ASCOM.Core.LoadTester is a simple NetCore 3.0 console app that demonstrates the loading and access of an ASCOM driver using DriverAccess.

This requires .Net Core 3.0 release 7 or higher to build. You can download this here: https://dotnet.microsoft.com/download/dotnet-core/3.0. Once this is installed you need to enable preview features in Visual Studio 2019.2 (Tools > Options > Environment > Preview Features) or install the current Visual Studio preview.

These will likely change a lot and will almost certainly have bugs as some behaviors have changed from .Net Framework to .Net Core. One thing I will evaluate going forward is splitting parts of these libraries into Net Standard libraries, allowing both NetCore and NetFX to benefit from the same code. However, currently these are NetCore only. It is likely that the UI components will remain NetCore only.

Known issues:
There are a couple of minor UI glitches in the preview framework.

There is an issue with .Net Core COM objects and ArrayLists (Get SupportedActions) and the current platforms implementation of DriverAccess. Basically ArrayLists are exposed across as just IEnumerable. The current platform fails to convert them because it tries to directly cast to ArrayList. The fix is very straight forward on the platform side. I have already fixed the .Net Core DriverAccess library and built and started to test the platform 6 DriveAccess library with the fix. I will submit a pull request to the main platform after some more testing is complete.