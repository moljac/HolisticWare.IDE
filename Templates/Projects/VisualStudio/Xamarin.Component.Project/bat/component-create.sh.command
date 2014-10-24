#!/bin/bash

MONO=/usr/bin/mono
# XPKG=sbin\xpkg\xpkg.exe
XPKG=sbin/xpkg/xamarin-component.exe
RAKE=/usr/bin/rake

# rake downloads xpkg and runs

PACKAGE=log4net

rm -fr *.xam *.xam.zip

./compile.sh.command
rm -fr 	./content/bin/*.dll
ls -al	./content/lib/

%MONO% \
	%XPKG% \
	create-manually \
	$PACKAGE-1.0.xam \
	--name="log4net" \
	--summary="log4net Xamarin component by Apache \software Foundation ported by HolisticWare" \
	--publisher="HolisticWare LLC" \
	--website="http://holisticware.net/" \
	--details="content/Details.md" \
	--license="content/License.md" \
	--getting-started="content/GettingStarted.md" \
	--icon="content/icons/$PACKAGE_128x128.png" \
	--icon="content/icons/$PACKAGE_512x512.png" \
	--library="ios":"content/bin/$PACKAGE.iOS.dll" \
	--sample="Sample for iOS. $PACKAGE sample for iOS.":"content/samples/$PACKAGE.iOS/$PACKAGE.iOS.sln" \
	--library="android":"content/bin/$PACKAGE.Android.dll" \
	--sample="Sample for Android. $PACKAGE sample for Android.":"content/samples/$PACKAGE.Android/$PACKAGE.Android.sln"
	

if [[ $? -ne 0 ]]
then
	read
fi