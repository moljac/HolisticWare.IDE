# Xamarin Studio F# Project creation errors


20140108 F# GTK App

File Widget could not be written.

	System.NullReferenceException: Object reference not set to an instance of an object
	  at MonoDevelop.GtkCore.GuiBuilder.GuiBuilderProject.AddNewComponent (System.Xml.XmlElement element) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.0-branch/cd02fcfb/source/monodevelop/main/src/addins/MonoDevelop.GtkCore/MonoDevelop.GtkCore.GuiBuilder/GuiBuilderProject.cs:268 
	  at MonoDevelop.GtkCore.WidgetFileDescriptionTemplate.AddToProject (MonoDevelop.Projects.SolutionItem policyParent, MonoDevelop.Projects.Project project, System.String language, System.String directory, System.String name) [0x00150] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.0-branch/cd02fcfb/source/monodevelop/main/src/addins/MonoDevelop.GtkCore/MonoDevelop.GtkCore/WidgetFileDescriptionTemplate.cs:115 
	  at MonoDevelop.Ide.Templates.ProjectDescriptor.InitializeItem (MonoDevelop.Projects.SolutionItem policyParent, MonoDevelop.Projects.ProjectCreateInformation projectCreateInformation, System.String defaultLanguage, MonoDevelop.Projects.SolutionEntityItem item) [0x00224] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.0-branch/cd02fcfb/source/monodevelop/main/src/core/MonoDevelop.Ide/MonoDevelop.Ide.Templates/ProjectDescriptor.cs:162 