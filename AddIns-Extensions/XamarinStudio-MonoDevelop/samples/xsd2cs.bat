@echo off

call "%PROGRAMFILES%\Microsoft Visual Studio 10.0\Common7\Tools\vsvars32.bat"

setlocal enabledelayedexpansion

:: xsd file.xdr [/outputdir:directory][/parameters:file.xml]
:: xsd file.xml [/outputdir:directory] [/parameters:file.xml]
:: xsd file.xsd {/classes | /dataset} [/element:element] 
::              [/enableLinqDataSet] [/language:language] 
::                           [/namespace:namespace] [/outputdir:directory] [URI:uri] 
::                           [/parameters:file.xml]
:: xsd {file.dll | file.exe} [/outputdir:directory] [/type:typename [...]][/parameters:file.xml]

FOR /f %%f IN ('dir /b /s *.xft.xsd') DO ( 

	echo ====================================================================
	set FILENAME="%%~ff"
	echo FILENAME = %FILENAME%
	
xsd ^
	%%~ff ^
	/classes ^
	/language:cs ^
	/outputdir:.\cs\xft\ 

)

FOR /f %%f IN ('dir /b /s *.xpt.xsd') DO ( 

	echo ====================================================================
	set FILENAME="%%~ff"
	echo FILENAME = %FILENAME%
	
xsd ^
	%%~ff ^
	/classes ^
	/language:cs ^
	/outputdir:.\cs\xpt\ 

)

if %errorlevel% neq 0 pause

