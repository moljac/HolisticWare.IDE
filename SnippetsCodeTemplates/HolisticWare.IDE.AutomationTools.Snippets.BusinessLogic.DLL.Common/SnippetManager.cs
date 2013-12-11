using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HolisticWare.IDE.AutomationTools.Snippets
{
	public partial class SnippetManager
	{
		public static string PathProgramFiles	= "";
		public static string PathUserProfile	= "";

		string LocationVisualStudioDefault = "";
		string LocationVisualStudioUser = "";

		public SnippetManager()
		{
			PathProgramFiles	= System.Environment.GetEnvironmentVariable("PROGRAMFILES");
			PathUserProfile		= System.Environment.GetEnvironmentVariable("USERPROFILE");

			LocationVisualStudioDefault = System.IO.Path.Combine(PathProgramFiles, "");
			LocationVisualStudioUser = System.IO.Path.Combine(PathUserProfile, @"\Documents\Visual Studio 2010\Code Snippets");

			return;
		}

		public string[] VisualStudioVersionsInstalled()
		{
			string[] retval = null;

			// Take a snapshot of the file system.
			System.IO.DirectoryInfo directory_info = new System.IO.DirectoryInfo(PathProgramFiles);

			// This method assumes that the application has discovery permissions 
			// for all folders under the specified path.
			List<System.IO.DirectoryInfo> folders = directory_info.GetDirectories
													(
													  "Microsoft Visual Studio*"
													, System.IO.SearchOption.TopDirectoryOnly
													).ToList();

			folders = 
					(
						from x in folders
							 where ! x.Name.Contains("SDK")
							select x
					).ToList();


			// search for devenv.exe
			//		%PROGRAMFILES%\Microsoft Visual Studio 10.0\Common7\IDE

			return retval;
		}

		public string[] XamarinStudioVersionsInstalled()
		{
			string[] retval = null;

			return retval;
		}
	}
}
