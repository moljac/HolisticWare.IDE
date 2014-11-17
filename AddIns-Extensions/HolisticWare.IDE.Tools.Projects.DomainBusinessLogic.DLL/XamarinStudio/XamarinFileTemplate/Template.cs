using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolisticWare.IDE.Tools.Projects.DomainBusinessLogic.XamarinStudio.XamarinFileTemplate
{


	/// <remarks/>
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class Template
	{

		private TemplateTemplateConfiguration templateConfigurationField;

		private TemplateTemplateFiles templateFilesField;

		private string originatorField;

		private string createdField;

		private string lastModifiedField;

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
		public TemplateTemplateFiles TemplateFiles
		{
			get
			{
				return this.templateFilesField;
			}
			set
			{
				this.templateFilesField = value;
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

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string lastModified
		{
			get
			{
				return this.lastModifiedField;
			}
			set
			{
				this.lastModifiedField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class TemplateTemplateConfiguration
	{

		private string _NameField;

		private string iconField;

		private string _CategoryField;

		private string languageNameField;

		private string projectTypeField;

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
		public string Icon
		{
			get
			{
				return this.iconField;
			}
			set
			{
				this.iconField = value;
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
		public string ProjectType
		{
			get
			{
				return this.projectTypeField;
			}
			set
			{
				this.projectTypeField = value;
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
	public partial class TemplateTemplateFiles
	{

		private TemplateTemplateFilesCodeDomFile codeDomFileField;

		/// <remarks/>
		public TemplateTemplateFilesCodeDomFile CodeDomFile
		{
			get
			{
				return this.codeDomFileField;
			}
			set
			{
				this.codeDomFileField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class TemplateTemplateFilesCodeDomFile
	{

		private TemplateTemplateFilesCodeDomFileCompileUnit compileUnitField;

		/// <remarks/>
		public TemplateTemplateFilesCodeDomFileCompileUnit CompileUnit
		{
			get
			{
				return this.compileUnitField;
			}
			set
			{
				this.compileUnitField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class TemplateTemplateFilesCodeDomFileCompileUnit
	{

		private TemplateTemplateFilesCodeDomFileCompileUnitNamespace[] namespacesField;

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayItemAttribute("Namespace", IsNullable = false)]
		public TemplateTemplateFilesCodeDomFileCompileUnitNamespace[] Namespaces
		{
			get
			{
				return this.namespacesField;
			}
			set
			{
				this.namespacesField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class TemplateTemplateFilesCodeDomFileCompileUnitNamespace
	{

		private TemplateTemplateFilesCodeDomFileCompileUnitNamespaceTypes typesField;

		private TemplateTemplateFilesCodeDomFileCompileUnitNamespaceNamespaceImport[] importsField;

		private string nameField;

		/// <remarks/>
		public TemplateTemplateFilesCodeDomFileCompileUnitNamespaceTypes Types
		{
			get
			{
				return this.typesField;
			}
			set
			{
				this.typesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayItemAttribute("NamespaceImport", IsNullable = false)]
		public TemplateTemplateFilesCodeDomFileCompileUnitNamespaceNamespaceImport[] Imports
		{
			get
			{
				return this.importsField;
			}
			set
			{
				this.importsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Name
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
	public partial class TemplateTemplateFilesCodeDomFileCompileUnitNamespaceTypes
	{

		private TemplateTemplateFilesCodeDomFileCompileUnitNamespaceTypesTypeDeclaration typeDeclarationField;

		/// <remarks/>
		public TemplateTemplateFilesCodeDomFileCompileUnitNamespaceTypesTypeDeclaration TypeDeclaration
		{
			get
			{
				return this.typeDeclarationField;
			}
			set
			{
				this.typeDeclarationField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class TemplateTemplateFilesCodeDomFileCompileUnitNamespaceTypesTypeDeclaration
	{

		private TemplateTemplateFilesCodeDomFileCompileUnitNamespaceTypesTypeDeclarationBaseTypes baseTypesField;

		private object membersField;

		private string nameField;

		private bool isClassField;

		/// <remarks/>
		public TemplateTemplateFilesCodeDomFileCompileUnitNamespaceTypesTypeDeclarationBaseTypes BaseTypes
		{
			get
			{
				return this.baseTypesField;
			}
			set
			{
				this.baseTypesField = value;
			}
		}

		/// <remarks/>
		public object Members
		{
			get
			{
				return this.membersField;
			}
			set
			{
				this.membersField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Name
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
		public bool IsClass
		{
			get
			{
				return this.isClassField;
			}
			set
			{
				this.isClassField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class TemplateTemplateFilesCodeDomFileCompileUnitNamespaceTypesTypeDeclarationBaseTypes
	{

		private TemplateTemplateFilesCodeDomFileCompileUnitNamespaceTypesTypeDeclarationBaseTypesTypeReference typeReferenceField;

		/// <remarks/>
		public TemplateTemplateFilesCodeDomFileCompileUnitNamespaceTypesTypeDeclarationBaseTypesTypeReference TypeReference
		{
			get
			{
				return this.typeReferenceField;
			}
			set
			{
				this.typeReferenceField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class TemplateTemplateFilesCodeDomFileCompileUnitNamespaceTypesTypeDeclarationBaseTypesTypeReference
	{

		private string baseTypeField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string BaseType
		{
			get
			{
				return this.baseTypeField;
			}
			set
			{
				this.baseTypeField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class TemplateTemplateFilesCodeDomFileCompileUnitNamespaceNamespaceImport
	{

		private string namespaceField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Namespace
		{
			get
			{
				return this.namespaceField;
			}
			set
			{
				this.namespaceField = value;
			}
		}
	}



}
