# Xamarin Studio Project types and Project GUIDs

## c / c++ / objective-c projects (*.cproj)

*	there's no ProjectTypeGuids element in xml project file


## c# projects

	find . -name "*proj" | xargs grep "ProjectTypeGuids" > ProjectTypeGuids.txt
	