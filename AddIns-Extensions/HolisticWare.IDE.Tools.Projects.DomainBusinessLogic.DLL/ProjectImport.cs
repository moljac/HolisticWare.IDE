using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolisticWare.IDE.Tools.Projects.DomainBusinessLogic
{
	
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public partial class ProjectImport
	{

		private string projectField;

		
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Project
		{
			get
			{
				return this.projectField;
			}
			set
			{
				this.projectField = value;
			}
		}
	}
}
