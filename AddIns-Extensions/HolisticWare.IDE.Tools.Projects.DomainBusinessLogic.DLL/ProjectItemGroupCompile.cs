using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolisticWare.IDE.Tools.Projects.DomainBusinessLogic
{
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public partial class ProjectItemGroupCompile
	{

		private string includeField;

		private string autoGenField;

		private string designTimeField;

		private string dependentUponField;

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


		/// <remarks/>
		public string AutoGen
		{
			get
			{
				return this.autoGenField;
			}
			set
			{
				this.autoGenField = value;
			}
		}

		/// <remarks/>
		public string DesignTime
		{
			get
			{
				return this.designTimeField;
			}
			set
			{
				this.designTimeField = value;
			}
		}

		/// <remarks/>
		public string DependentUpon
		{
			get
			{
				return this.dependentUponField;
			}
			set
			{
				this.dependentUponField = value;
			}
		}
	
	
	}
}
