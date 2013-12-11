
call "%PROGRAMFILES%\Microsoft Visual Studio 10.0\Common7\Tools\vsvars32.bat"

:: xsd file.xdr [/outputdir:directory][/parameters:file.xml]
:: xsd file.xml [/outputdir:directory] [/parameters:file.xml]
:: xsd file.xsd {/classes | /dataset} [/element:element] 
::              [/enableLinqDataSet] [/language:language] 
::                           [/namespace:namespace] [/outputdir:directory] [URI:uri] 
::                           [/parameters:file.xml]
:: xsd {file.dll | file.exe} [/outputdir:directory] [/type:typename [...]][/parameters:file.xml]


xsd ^
	/classes ^
	/language:cs ^
	/namespace:HolisticWare.IDE.AutomationTools.Snippets.MonoDevelop ^
	/outputdir:..\cs-generated\ ^
	"..\xsd\RazorCodeTemplates.[from-RazorCodeTemplates-template.xml].template.xsd"



pause
