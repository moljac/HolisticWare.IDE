
set PATH_TANSFORMER=.\Xamarin.iOS.UnifiedSupportTransformer.Console.exe

%PATH_TANSFORMER% ^
		-i originals\PinterestSDK.csproj ^
		-o transformed\

dir		transformed\*.*

pause

del /y	transformed\*.*
dir		transformed\*.*

%PATH_TANSFORMER% ^
		-i originals\ ^
		-o transformed\



