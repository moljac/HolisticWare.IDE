::@echo off
setlocal ENABLEDELAYEDEXPANSION

::call "%PROGRAMFILES%\Microsoft Visual Studio 10.0\VC\vcvarsall.bat"
call "%PROGRAMFILES(x86)%\Microsoft Visual Studio 11.0\VC\vcvarsall.bat"


:: ======================================================================================
:: Locations of the library/utility/app/control to be packaged into Xamarin.Component
::
set ZIP=..\sbin\7za.exe
::
set FOLDER_CONTENT_LIBS=..\content\libs
set FOLDER_CONTENT_SAMPLES=..\content\samples
::
::
set COMPONENT_NAME=XamarinSampleComponent
set COMPONENT_VERSION=1.0
:: ======================================================================================

set COMPONENT_NAME_FOR_PACKAGE=%COMPONENT_NAME%-%COMPONENT_VERSION%

echo f | xcopy /f /y ^
	..\%COMPONENT_NAME_FOR_PACKAGE%.xam ^
	..\%COMPONENT_NAME_FOR_PACKAGE%.zip

del /q /s ..\test\*.*

%ZIP% x ..\XamarinSampleComponent-1.0.zip -o..\test\


::	..\%COMPONENT_NAME_FOR_PACKAGE%.xam.zip


devenv ^
	..\test\%COMPONENT_NAME%-%COMPONENT_VERSION%\samples\AndroidApplication1\AndroidApplication1.sln

devenv ^
	..\test\%COMPONENT_NAME%-%COMPONENT_VERSION%\samples\IOSApplication\IOSApplication.sln

@IF %ERRORLEVEL% NEQ 0 PAUSE	
