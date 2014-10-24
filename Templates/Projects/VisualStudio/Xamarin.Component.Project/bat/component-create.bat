:: component-create.bat
:: @echo off
setlocal ENABLEDELAYEDEXPANSION

set MONO="%PROGRAMFILES(X86)%\Mono-3.2.3\bin\mono.exe"
::set XPKG=sbin\xpkg\xpkg.exe
set XPKG=sbin\xpkg\xamarin-component.exe
set RAKE=C:\bin\Ruby200\bin\rake

:: rake downloads xpkg and runs:

set PACKAGE=log4net

DEL /Q *.xam *.xam.zip

dir /s .\content\bin\*.dll
dir /s .\content\lib\

%MONO% ^
	%XPKG% ^
	create-manually ^
	%PACKAGE%-1.0.xam ^
	--name="log4net" ^
	--summary="log4net library is a tool to help the programmer output log statements to a variety of output targets" ^
	--publisher="HolisticWare LLC" ^
	--website="http://holisticware.net/" ^
	--details="content/Details.md" ^
	--license="content/License.md" ^
	--getting-started="content/GettingStarted.md" ^
	--icon="content/icons/%PACKAGE%_128x128.png" ^
	--icon="content/icons/%PACKAGE%_512x512.png" ^
	--library="ios":"content/bin/%PACKAGE%.XamariniOS.dll" ^
	--sample="Sample for iOS. %PACKAGE% sample for iOS.":"content/samples/%PACKAGE%.iOS/%PACKAGE%.iOS.sln" ^
	--library="android":"content/bin/%PACKAGE%.XamarinAndroid.dll" ^
	--sample="Sample for Android. %PACKAGE% sample for Android.":"content/samples/%PACKAGE%.Android/%PACKAGE%.Android.sln"
	

@IF %ERRORLEVEL% NEQ 0 PAUSE