using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolisticWare.IDE.Tools.Projects.DomainBusinessLogic.XamarinStudio.XamarinProjectTemplate
{


	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class Template
	{

		private TemplateTemplateConfiguration templateConfigurationField;

		private TemplateActions actionsField;

		private TemplateCombine combineField;

		private string originatorField;

		private string createdField;

		/// <remarks/>
		public TemplateTemplateConfiguration TemplateConfiguration
		{
			get
			{
				return this.templateConfigurationField;
			}
			set
			{
				this.templateConfigurationField = value;
			}
		}

		/// <remarks/>
		public TemplateActions Actions
		{
			get
			{
				return this.actionsField;
			}
			set
			{
				this.actionsField = value;
			}
		}

		/// <remarks/>
		public TemplateCombine Combine
		{
			get
			{
				return this.combineField;
			}
			set
			{
				this.combineField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string originator
		{
			get
			{
				return this.originatorField;
			}
			set
			{
				this.originatorField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string created
		{
			get
			{
				return this.createdField;
			}
			set
			{
				this.createdField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class TemplateTemplateConfiguration
	{

		private string _NameField;

		private string _CategoryField;

		private string languageNameField;

		private string _DescriptionField;

		/// <remarks/>
		public string _Name
		{
			get
			{
				return this._NameField;
			}
			set
			{
				this._NameField = value;
			}
		}

		/// <remarks/>
		public string _Category
		{
			get
			{
				return this._CategoryField;
			}
			set
			{
				this._CategoryField = value;
			}
		}

		/// <remarks/>
		public string LanguageName
		{
			get
			{
				return this.languageNameField;
			}
			set
			{
				this.languageNameField = value;
			}
		}

		/// <remarks/>
		public string _Description
		{
			get
			{
				return this._DescriptionField;
			}
			set
			{
				this._DescriptionField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class TemplateActions
	{

		private TemplateActionsOpen openField;

		/// <remarks/>
		public TemplateActionsOpen Open
		{
			get
			{
				return this.openField;
			}
			set
			{
				this.openField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class TemplateActionsOpen
	{

		private string filenameField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string filename
		{
			get
			{
				return this.filenameField;
			}
			set
			{
				this.filenameField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class TemplateCombine
	{

		private TemplateCombineOptions optionsField;

		private TemplateCombineProject projectField;

		private string nameField;

		private string directoryField;

		/// <remarks/>
		public TemplateCombineOptions Options
		{
			get
			{
				return this.optionsField;
			}
			set
			{
				this.optionsField = value;
			}
		}

		/// <remarks/>
		public TemplateCombineProject Project
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

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string directory
		{
			get
			{
				return this.directoryField;
			}
			set
			{
				this.directoryField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class TemplateCombineOptions
	{

		private string startupProjectField;

		/// <remarks/>
		public string StartupProject
		{
			get
			{
				return this.startupProjectField;
			}
			set
			{
				this.startupProjectField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class TemplateCombineProject
	{

		private object optionsField;

		private TemplateCombineProjectReference[] referencesField;

		private TemplateCombineProjectFiles filesField;

		private string nameField;

		private string directoryField;

		private string typeField;

		/// <remarks/>
		public object Options
		{
			get
			{
				return this.optionsField;
			}
			set
			{
				this.optionsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayItemAttribute("Reference", IsNullable = false)]
		public TemplateCombineProjectReference[] References
		{
			get
			{
				return this.referencesField;
			}
			set
			{
				this.referencesField = value;
			}
		}

		/// <remarks/>
		public TemplateCombineProjectFiles Files
		{
			get
			{
				return this.filesField;
			}
			set
			{
				this.filesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string directory
		{
			get
			{
				return this.directoryField;
			}
			set
			{
				this.directoryField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class TemplateCombineProjectReference
	{

		private string typeField;

		private string reftoField;

		private bool specificVersionField;

		private bool specificVersionFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string refto
		{
			get
			{
				return this.reftoField;
			}
			set
			{
				this.reftoField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public bool SpecificVersion
		{
			get
			{
				return this.specificVersionField;
			}
			set
			{
				this.specificVersionField = value;
			}
		}

		/// <remarks/>
		public bool SpecificVersionSpecified
		{
			get
			{
				return this.specificVersionFieldSpecified;
			}
			set
			{
				this.specificVersionFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class TemplateCombineProjectFiles
	{

		private TemplateCombineProjectFilesDirectory directoryField;

		private TemplateCombineProjectFilesFileTemplateReference[] fileTemplateReferenceField;

		private TemplateCombineProjectFilesFile[] fileField;

		/// <remarks/>
		public TemplateCombineProjectFilesDirectory Directory
		{
			get
			{
				return this.directoryField;
			}
			set
			{
				this.directoryField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("FileTemplateReference")]
		public TemplateCombineProjectFilesFileTemplateReference[] FileTemplateReference
		{
			get
			{
				return this.fileTemplateReferenceField;
			}
			set
			{
				this.fileTemplateReferenceField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("File")]
		public TemplateCombineProjectFilesFile[] File
		{
			get
			{
				return this.fileField;
			}
			set
			{
				this.fileField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class TemplateCombineProjectFilesDirectory
	{

		private string nameField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class TemplateCombineProjectFilesFileTemplateReference
	{

		private string templateIDField;

		private string nameField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string TemplateID
		{
			get
			{
				return this.templateIDField;
			}
			set
			{
				this.templateIDField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class TemplateCombineProjectFilesFile
	{

		private string nameField;

		private string dependsOnField;

		private string showAutogenerationNoticeField;

		private string addStandardHeaderField;

		private string suppressAutoOpenField;

		private string valueField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string DependsOn
		{
			get
			{
				return this.dependsOnField;
			}
			set
			{
				this.dependsOnField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ShowAutogenerationNotice
		{
			get
			{
				return this.showAutogenerationNoticeField;
			}
			set
			{
				this.showAutogenerationNoticeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string AddStandardHeader
		{
			get
			{
				return this.addStandardHeaderField;
			}
			set
			{
				this.addStandardHeaderField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string SuppressAutoOpen
		{
			get
			{
				return this.suppressAutoOpenField;
			}
			set
			{
				this.suppressAutoOpenField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public string Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}
	}


}
