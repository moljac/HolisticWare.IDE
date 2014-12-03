using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolisticWare.IDE.Tools.Projects.DomainBusinessLogic.tmp
{


	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/developer/msbuild/2003", IsNullable = false)]
	public partial class Project
	{

		private ProjectPropertyGroup[] propertyGroupField;

		private ProjectItemGroup itemGroupField;

		private string defaultTargetsField;

		private decimal toolsVersionField;

		/// <remarks/>
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

		/// <remarks/>
		public ProjectItemGroup ItemGroup
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

		/// <remarks/>
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

		/// <remarks/>
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
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public partial class ProjectPropertyGroup
	{

		private bool debugSymbolsField;

		private bool debugSymbolsFieldSpecified;

		private string outputPathField;

		private bool externalconsoleField;

		private bool externalconsoleFieldSpecified;

		private string outputNameField;

		private string compileTargetField;

		private byte optimizationLevelField;

		private bool optimizationLevelFieldSpecified;

		private string defineSymbolsField;

		private string sourceDirectoryField;

		private ProjectPropertyGroupConfiguration configurationField;

		private ProjectPropertyGroupPlatform platformField;

		private string productVersionField;

		private decimal schemaVersionField;

		private bool schemaVersionFieldSpecified;

		private string projectGuidField;

		private ProjectPropertyGroupCompiler compilerField;

		private string languageField;

		private string targetField;

		private string conditionField;

		/// <remarks/>
		public bool DebugSymbols
		{
			get
			{
				return this.debugSymbolsField;
			}
			set
			{
				this.debugSymbolsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool DebugSymbolsSpecified
		{
			get
			{
				return this.debugSymbolsFieldSpecified;
			}
			set
			{
				this.debugSymbolsFieldSpecified = value;
			}
		}

		/// <remarks/>
		public string OutputPath
		{
			get
			{
				return this.outputPathField;
			}
			set
			{
				this.outputPathField = value;
			}
		}

		/// <remarks/>
		public bool Externalconsole
		{
			get
			{
				return this.externalconsoleField;
			}
			set
			{
				this.externalconsoleField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool ExternalconsoleSpecified
		{
			get
			{
				return this.externalconsoleFieldSpecified;
			}
			set
			{
				this.externalconsoleFieldSpecified = value;
			}
		}

		/// <remarks/>
		public string OutputName
		{
			get
			{
				return this.outputNameField;
			}
			set
			{
				this.outputNameField = value;
			}
		}

		/// <remarks/>
		public string CompileTarget
		{
			get
			{
				return this.compileTargetField;
			}
			set
			{
				this.compileTargetField = value;
			}
		}

		/// <remarks/>
		public byte OptimizationLevel
		{
			get
			{
				return this.optimizationLevelField;
			}
			set
			{
				this.optimizationLevelField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool OptimizationLevelSpecified
		{
			get
			{
				return this.optimizationLevelFieldSpecified;
			}
			set
			{
				this.optimizationLevelFieldSpecified = value;
			}
		}

		/// <remarks/>
		public string DefineSymbols
		{
			get
			{
				return this.defineSymbolsField;
			}
			set
			{
				this.defineSymbolsField = value;
			}
		}

		/// <remarks/>
		public string SourceDirectory
		{
			get
			{
				return this.sourceDirectoryField;
			}
			set
			{
				this.sourceDirectoryField = value;
			}
		}

		/// <remarks/>
		public ProjectPropertyGroupConfiguration Configuration
		{
			get
			{
				return this.configurationField;
			}
			set
			{
				this.configurationField = value;
			}
		}

		/// <remarks/>
		public ProjectPropertyGroupPlatform Platform
		{
			get
			{
				return this.platformField;
			}
			set
			{
				this.platformField = value;
			}
		}

		/// <remarks/>
		public string ProductVersion
		{
			get
			{
				return this.productVersionField;
			}
			set
			{
				this.productVersionField = value;
			}
		}

		/// <remarks/>
		public decimal SchemaVersion
		{
			get
			{
				return this.schemaVersionField;
			}
			set
			{
				this.schemaVersionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool SchemaVersionSpecified
		{
			get
			{
				return this.schemaVersionFieldSpecified;
			}
			set
			{
				this.schemaVersionFieldSpecified = value;
			}
		}

		/// <remarks/>
		public string ProjectGuid
		{
			get
			{
				return this.projectGuidField;
			}
			set
			{
				this.projectGuidField = value;
			}
		}

		/// <remarks/>
		public ProjectPropertyGroupCompiler Compiler
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

		/// <remarks/>
		public string Language
		{
			get
			{
				return this.languageField;
			}
			set
			{
				this.languageField = value;
			}
		}

		/// <remarks/>
		public string Target
		{
			get
			{
				return this.targetField;
			}
			set
			{
				this.targetField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Condition
		{
			get
			{
				return this.conditionField;
			}
			set
			{
				this.conditionField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public partial class ProjectPropertyGroupConfiguration
	{

		private string conditionField;

		private string valueField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Condition
		{
			get
			{
				return this.conditionField;
			}
			set
			{
				this.conditionField = value;
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

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public partial class ProjectPropertyGroupPlatform
	{

		private string conditionField;

		private string valueField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Condition
		{
			get
			{
				return this.conditionField;
			}
			set
			{
				this.conditionField = value;
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

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public partial class ProjectPropertyGroupCompilerCompiler
	{

		private string ctypeField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ctype
		{
			get
			{
				return this.ctypeField;
			}
			set
			{
				this.ctypeField = value;
			}
		}
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public partial class ProjectItemGroup
	{

		private ProjectItemGroupCompile compileField;

		/// <remarks/>
		public ProjectItemGroupCompile Compile
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
	}

	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public partial class ProjectItemGroupCompile
	{

		private string includeField;

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