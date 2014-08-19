@echo off
call "%PROGRAMFILES%\Microsoft Visual Studio 10.0\VC\vcvarsall.bat"


rmdir /q /s .\bin\
rmdir /q /s .\bin\

:: =============================================================================================
:: select solution file sln to compile all projects
::		..\SharpSerializer.sln
:: project files to narrow selection
:: output of compilation is in <ProjectName>\bin\Debug.msbuild\
set PROJECTS=^
	..\MonoVersal.MarkDown.MarkDownDeep.XA\MonoVersal.MarkDown.MarkDownDeep.XA.csproj ^
	..\MonoVersal.MarkDown.MarkDownDeep.XI\MonoVersal.MarkDown.MarkDownDeep.XI.csproj 

set CONFIGURATION=Debug
::set CONFIGURATION=Release

for %%p IN (%PROJECTS%) DO (
	echo ------------------------------------------------------------------
	echo %%p
	msbuild %%p ^
			/p:Configuration=%CONFIGURATION% ^
			/property:OutDir=.\bin\%CONFIGURATION%.msbuild\

	msbuild %%p ^
			/p:Configuration=%CONFIGURATION% ^
			/property:OutDir=.\bin\%CONFIGURATION%.msbuild\
			
)
:: =============================================================================================

@IF %ERRORLEVEL% NEQ 0 PAUSE	
