using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolisticWare.IDE.Tools.Projects.DomainBusinessLogic
{
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public partial class ProjectItemGroup
	{

		private ProjectItemGroupObjcBindingCoreSource objcBindingCoreSourceField;

		private ProjectItemGroupObjcBindingApiDefinition objcBindingApiDefinitionField;

		private ProjectItemGroupFolder folderField;

		private ProjectItemGroupReference[] referenceField;

		
		public ProjectItemGroupObjcBindingCoreSource ObjcBindingCoreSource
		{
			get
			{
				return this.objcBindingCoreSourceField;
			}
			set
			{
				this.objcBindingCoreSourceField = value;
			}
		}

		
		public ProjectItemGroupObjcBindingApiDefinition ObjcBindingApiDefinition
		{
			get
			{
				return this.objcBindingApiDefinitionField;
			}
			set
			{
				this.objcBindingApiDefinitionField = value;
			}
		}

		
		public ProjectItemGroupFolder Folder
		{
			get
			{
				return this.folderField;
			}
			set
			{
				this.folderField = value;
			}
		}

		
		[System.Xml.Serialization.XmlElementAttribute("Reference")]
		public ProjectItemGroupReference[] Reference
		{
			get
			{
				return this.referenceField;
			}
			set
			{
				this.referenceField = value;
			}
		}
	}
}
