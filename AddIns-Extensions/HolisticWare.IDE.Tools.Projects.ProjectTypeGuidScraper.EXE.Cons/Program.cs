using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HolisticWare.IDE.Tools.Projects.DomainBusinessLogic;

namespace HolisticWare.IDE.Tools.Projects.ProjectTypeGuidScraper.EXE
{
	class Program
	{
		static void Main(string[] args)
		{
			// Directory("*.*proj")
			//	*.csproj
			//	*.fsproj
			//	*.vbproj
			//	*.cxproj
			//	?????
			Project project = new Project();


			string[] files = null;
			string searchPattern = "*proj";

			string path = System.IO.Path.Combine("..", "..", "..", "..", "Templates", "Projects");
			files = System.IO.Directory.GetFiles(path, searchPattern, System.IO.SearchOption.AllDirectories);

			return;
		}
	}
}
