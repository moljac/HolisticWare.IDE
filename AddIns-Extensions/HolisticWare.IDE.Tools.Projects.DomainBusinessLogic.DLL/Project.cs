using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolisticWare.IDE.Tools.Projects.DomainBusinessLogic
{

	
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/developer/msbuild/2003", IsNullable = false)]
	public partial class Project
	{

		private ProjectPropertyGroup[] propertyGroupField;

		private ProjectItemGroup[] itemGroupField;

		private ProjectImport[] importField;

		private string defaultTargetsField;

		private decimal toolsVersionField;

	
		[System.Xml.Serialization.XmlElementAttribute("PropertyGroup")]
		public ProjectPropertyGroup[] PropertyGroup
		{
			get
			{
				return this.propertyGroupField;
			}
			set
			{
				this.propertyGroupField = value;
			}
		}

		
		[System.Xml.Serialization.XmlElementAttribute("ItemGroup")]
		public ProjectItemGroup[] ItemGroup
		{
			get
			{
				return this.itemGroupField;
			}
			set
			{
				this.itemGroupField = value;
			}
		}


		[System.Xml.Serialization.XmlElementAttribute("Import")]
		public ProjectImport[] Import
		{
			get
			{
				return this.importField;
			}
			set
			{
				this.importField = value;
			}
		}

		
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string DefaultTargets
		{
			get
			{
				return this.defaultTargetsField;
			}
			set
			{
				this.defaultTargetsField = value;
			}
		}

		
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public decimal ToolsVersion
		{
			get
			{
				return this.toolsVersionField;
			}
			set
			{
				this.toolsVersionField = value;
			}
		}



		private ProjectProjectExtensions projectExtensionsField;

		/// <remarks/>
		public ProjectProjectExtensions ProjectExtensions
		{
			get
			{
				return this.projectExtensionsField;
			}
			set
			{
				this.projectExtensionsField = value;
			}
		}




	}





}
