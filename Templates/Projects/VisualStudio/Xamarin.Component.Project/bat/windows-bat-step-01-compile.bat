@echo off
setlocal ENABLEDELAYEDEXPANSION

::call "%PROGRAMFILES%\Microsoft Visual Studio 10.0\VC\vcvarsall.bat"
call "%PROGRAMFILES(x86)%\Microsoft Visual Studio 11.0\VC\vcvarsall.bat"


rmdir /q /s ..\bin\
rmdir /q /s ..\obj\
rmdir /q /s ..\logs\
rmdir /q /s ..\content\lib\

mkdir ..\logs\


:: ======================================================================================
:: Locations of the library/utility/app/control to be packaged into Xamarin.Component
set FOLDER_ANDROID=..\..\AndroidApplication1
set FOLDER_IOS=..\..\IOSApplication1
::
:: Projects of the library/utility/app/control to be packaged into Xamarin.Component
set PROJECT_ANDROID=AndroidApplication1.csproj
set PROJECT_IOS=IOSApplication.csproj
::
:: Logs
set LOG_ANDROID=..\logs\Build.Android.Log
set LOG_IOS=..\logs\Build.IOS.Log
::
:: ======================================================================================


msbuild ^
		%FOLDER_ANDROID%\%PROJECT_ANDROID% ^
		/p:Configuration=Debug ^
		/fileLogger ^
		/flp:logfile=%LOG_ANDROID% ^
		/detailedsummary ^
		/verbosity:diagnostic

msbuild ^
		%FOLDER_ANDROID%\%PROJECT_ANDROID% ^
		/p:Configuration=Release ^
		/fileLogger ^
		/flp:logfile=%LOG_ANDROID% ^
		/detailedsummary ^
		/verbosity:diagnostic

msbuild ^
		..\..\IOSApplication\IOSApplication.csproj ^
		/p:Configuration=Debug ^
		/fileLogger ^
		/flp:logfile=%LOG_IOS% ^
		/detailedsummary ^
		/verbosity:diagnostic

msbuild ^
		..\..\IOSApplication\IOSApplication.csproj ^
		/p:Configuration=Release ^
		/fileLogger ^
		/flp:logfile=%LOG_IOS% ^
		/detailedsummary ^
		/verbosity:diagnostic

@IF %ERRORLEVEL% NEQ 0 PAUSE	
