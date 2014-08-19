:: component-create.bat
@echo off
setlocal ENABLEDELAYEDEXPANSION

set MONO="%PROGRAMFILES%\Mono-3.0.9\bin\mono.exe"
::set XPKG=sbin\xpkg\xpkg.exe
set XPKG=sbin\xpkg\xamarin-component.exe
set RAKE=C:\bin\Ruby200\bin\rake

:: rake downloads xpkg and runs:

set PACKAGE=MarkDownDeep

set ASSEMBLIES=^
	..\MonoVersal.MarkDown.MarkDownDeep.XA\bin\Release\MonoVersal.MarkDown.MarkDownDeep.XA.dll ^
	..\MonoVersal.MarkDown.MarkDownDeep.XI\bin\Release\MonoVersal.MarkDown.MarkDownDeep.XI.dll

set SAMPLES=^
	..\XSample.MarkDownDeep.XA ^
	..\XSample.MarkDownDeep.XI
	
:: http://www.dostips.com/DtTipsStringManipulation.php
:: 

call .\compile.bat

echo ===========================================================================
echo copying assemblies
for %%A IN (%ASSEMBLIES%) DO (
	echo -----------------------------------
	echo %%A
	dir %%A
	set FILENAME=%%~nA
	echo !FILENAME!

	:: not sure for filenames, so let's do some string replacements
	:: not wise and not needed (change project properties)

::		set FILENAME=!FILENAME:.Library=!
::		set FILENAME=!FILENAME:.monodroid=.Android!
::		set FILENAME=!FILENAME:.MonoDroid=.Android!
::		set FILENAME=!FILENAME:.monoforandroid=.Android!
::		set FILENAME=!FILENAME:.MonoForAndroid=.Android!
::	
::		set FILENAME=!FILENAME:.monotouch=.iOS!
::		set FILENAME=!FILENAME:.MonoTouch=.iOS!
::	
::		set FILENAME=!FILENAME!.dll
::		echo !FILENAME!
::		echo f | xcopy /f /y %%A .\content\bin\!FILENAME!

		echo f | xcopy /f /y %%A .\content\bin\
		echo f | xcopy /f /y %%A .\content\lib\
)
echo ===========================================================================

echo ===========================================================================
echo copying assemblies
for %%A IN (%SAMPLES%) DO (
	echo -----------------------------------
	echo %%A
	dir %%A
	set FILENAME=%%~nA
	echo !FILENAME!

	echo f | xcopy /f /s /y %%A .\content\samples\!FILENAME!\
)
echo ===========================================================================

dir .\content\bin\*.dll
DEL /Q *.xam *.xam.zip

%MONO% ^
	%XPKG% ^
	create-manually ^
	%PACKAGE%-1.0.xam ^
	--name="MarkDownDeep" ^
	--summary="MarkDownDeep Xamarin component by TopTenSoftware ported by HolisticWare" ^
	--publisher="HolisticWare LLC" ^
	--website="http://holisticware.net/" ^
	--details="content/Details.md" ^
	--license="content/License.md" ^
	--getting-started="content/GettingStarted.md" ^
	--icon="content/icons/%PACKAGE%_128x128.png" ^
	--icon="content/icons/%PACKAGE%_512x512.png" ^
	--library="ios":"content/bin/%PACKAGE%.iOS.dll" ^
	--library="android":"content/bin/%PACKAGE%.Android.dll" ^
	--sample="Sample for iOS. %PACKAGE% sample for iOS.":"content/samples/%PACKAGE%.iOS/%PACKAGE%.iOS.sln" ^
	--sample="Sample for Android. %PACKAGE% sample for Android.":"content/samples/%PACKAGE%.Android/%PACKAGE%.Android.sln"
	

@IF %ERRORLEVEL% NEQ 0 PAUSE