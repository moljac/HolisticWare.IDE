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


		private ProjectItemGroupFolder[] folderField;

		private ProjectItemGroupReference[] referenceField;

		private ProjectItemGroupCompile[] compileField;

		private ProjectItemGroupContent[] contentField;

		private ProjectItemGroupNone[] noneField;

		//-----------------------------------------------------------------------
		// Xamarin.Android
		//................................................................
		private ProjectItemGroupAndroidResource androidResourceField;
		//................................................................
		// Xamarin.Android Bindings
		private ProjectItemGroupTransformFile[] transformFileField;
		//-----------------------------------------------------------------------

		//ios
		private ProjectItemGroupObjcBindingCoreSource objcBindingCoreSourceField;

		private ProjectItemGroupObjcBindingApiDefinition objcBindingApiDefinitionField;

	
		//WP
		private ProjectItemGroupApplicationDefinition applicationDefinitionField;

		private ProjectItemGroupPage pageField;

		private ProjectItemGroupEmbeddedResource embeddedResourceField;
		private ProjectItemGroupProjectReference projectReferenceField;



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


		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Folder")]
		public ProjectItemGroupFolder[] Folder
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



		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Compile")]
		public ProjectItemGroupCompile[] Compile
		{
			get
			{
				return this.compileField;
			}
			set
			{
				this.compileField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Content")]
		public ProjectItemGroupContent[] Content
		{
			get
			{
				return this.contentField;
			}
			set
			{
				this.contentField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("None")]
		public ProjectItemGroupNone[] None
		{
			get
			{
				return this.noneField;
			}
			set
			{
				this.noneField = value;
			}
		}

		/// <remarks/>
		public ProjectItemGroupProjectReference ProjectReference
		{
			get
			{
				return this.projectReferenceField;
			}
			set
			{
				this.projectReferenceField = value;
			}
		}

		public ProjectItemGroupEmbeddedResource EmbeddedResource
		{
			get
			{
				return this.embeddedResourceField;
			}
			set
			{
				this.embeddedResourceField = value;
			}
		}

		
		public ProjectItemGroupAndroidResource AndroidResource
		{
			get
			{
				return this.androidResourceField;
			}
			set
			{
				this.androidResourceField = value;
			}
		}

		[System.Xml.Serialization.XmlElementAttribute("TransformFile")]
		public ProjectItemGroupTransformFile[] TransformFile
		{
			get
			{
				return this.transformFileField;
			}
			set
			{
				this.transformFileField = value;
			}
		}





		/// <remarks/>
		public ProjectItemGroupApplicationDefinition ApplicationDefinition
		{
			get
			{
				return this.applicationDefinitionField;
			}
			set
			{
				this.applicationDefinitionField = value;
			}
		}

		/// <remarks/>
		public ProjectItemGroupPage Page
		{
			get
			{
				return this.pageField;
			}
			set
			{
				this.pageField = value;
			}
		}
	
	
	
	
	
	
	
	
	}
}
