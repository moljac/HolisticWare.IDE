@echo off
call "%PROGRAMFILES%\Microsoft Visual Studio 10.0\VC\vcvarsall.bat"


rmdir /q /s .\bin\
rmdir /q /s .\content\bin\
rmdir /q /s .\content\lib

msbuild ..\MonoVersal.MarkDown.log4net.XA\MonoVersal.MarkDown.log4net.XA.csproj ^
		/p:Configuration=Release ^
		/property:OutDir=..\XamarinComponent.log4net\content\bin\

msbuild ..\MonoVersal.MarkDown.log4net.XI\MonoVersal.MarkDown.log4net.XI.csproj ^
		/p:Configuration=Release ^
		/property:OutDir=..\XamarinComponent.log4net\content\bin\

echo ======================================================================================
echo creating references for component samples in content\lib
echo folders 
echo		lib\android 
echo and
echo 		lib\ios
echo are generated during xam packaging
echo only Release build is for component
echo ======================================================================================

msbuild ..\MonoVersal.MarkDown.log4net.XA\MonoVersal.MarkDown.log4net.XA.csproj ^
		/p:Configuration=Release ^
		/property:OutDir=..\XamarinComponent.log4net\content\lib\android

msbuild ..\MonoVersal.MarkDown.log4net.XI\MonoVersal.MarkDown.log4net.XI.csproj ^
		/p:Configuration=Release ^
		/property:OutDir=..\XamarinComponent.log4net\content\lib\ios


@IF %ERRORLEVEL% NEQ 0 PAUSE	
