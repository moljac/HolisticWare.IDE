using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolisticWare.IDE.Tools.Projects.DomainBusinessLogic
{
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public partial class ProjectPropertyGroupCompiler
	{

		private ProjectPropertyGroupCompilerCompiler compilerField;

		/// <remarks/>
		public ProjectPropertyGroupCompilerCompiler Compiler
		{
			get
			{
				return this.compilerField;
			}
			set
			{
				this.compilerField = value;
			}
		}
	}
}
