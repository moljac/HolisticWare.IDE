using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolisticWare.IDE.Tools.Projects.DomainBusinessLogic
{
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public partial class ProjectItemGroupEmbeddedResource
	{

		private string generatorField;

		private string lastGenOutputField;

		private string includeField;

		/// <remarks/>
		public string Generator
		{
			get
			{
				return this.generatorField;
			}
			set
			{
				this.generatorField = value;
			}
		}

		/// <remarks/>
		public string LastGenOutput
		{
			get
			{
				return this.lastGenOutputField;
			}
			set
			{
				this.lastGenOutputField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Include
		{
			get
			{
				return this.includeField;
			}
			set
			{
				this.includeField = value;
			}
		}
	}
}
