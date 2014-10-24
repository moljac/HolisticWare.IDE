using System;
using Mono.Addins;
using Mono.Addins.Description;

[assembly:Addin (
	"HolisticWare.IDE.Productivity.CopyPasteAsLink", 
	Namespace = "HolisticWare.IDE.Productivity.CopyPasteAsLink",
	Version = "1.0"
)]

[assembly:AddinName ("HolisticWare.IDE.Productivity.CopyPasteAsLink")]
[assembly:AddinCategory ("HolisticWare.IDE.Productivity.CopyPasteAsLink")]
[assembly:AddinDescription ("HolisticWare.IDE.Productivity.CopyPasteAsLink")]
[assembly:AddinAuthor ("moljac")]

[assembly:AddinDependency ("::MonoDevelop.Core", MonoDevelop.BuildInfo.Version)]
[assembly:AddinDependency ("::MonoDevelop.Ide", MonoDevelop.BuildInfo.Version)]
