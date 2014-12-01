using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolisticWare.IDE.Tools.Projects.DomainBusinessLogic
{
	
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public partial class ProjectPropertyGroup
	{

		private bool debugSymbolsField;

		private bool debugSymbolsFieldSpecified;

		private string debugTypeField;

		private bool optimizeField;

		private bool optimizeFieldSpecified;

		private string outputPathField;

		private string appDesignerFolderField;
		
		private string defineConstantsField;

		private string errorReportField;

		private byte warningLevelField;

		private bool warningLevelFieldSpecified;

		private bool consolePauseField;

		private bool consolePauseFieldSpecified;

		private bool allowUnsafeBlocksField;

		private bool allowUnsafeBlocksFieldSpecified;

		private ProjectPropertyGroupCustomCommands customCommandsField;

		private ProjectPropertyGroupConfiguration configurationField;

		private ProjectPropertyGroupPlatform platformField;

		private string projectTypeGuidsField;

		private string productVersionField;

		private decimal schemaVersionField;

		private bool schemaVersionFieldSpecified;

		private string projectGuidField;

		private string outputTypeField;

		private string rootNamespaceField;

		private string iPhoneResourcePrefixField;

		private string assemblyNameField;

		private string targetFrameworkIdentifierField;

		private string conditionField;

		private string targetFrameworkVersionField;

		private string targetFrameworkProfileField;

		private ushort fileAlignmentField;

		private bool fileAlignmentFieldSpecified;

		private string postBuildEventField;

		private string platformTargetField;



		private bool androidApplicationField;

		private bool androidApplicationFieldSpecified;

		private string androidResgenFileField;

		private string generateSerializationAssembliesField;

		private string androidManifestField;

		private string androidUseSharedRuntimeField;

		private string androidLinkModeField;

		
		
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


		public string DebugType
		{
			get
			{
				return this.debugTypeField;
			}
			set
			{
				this.debugTypeField = value;
			}
		}

		
		public bool Optimize
		{
			get
			{
				return this.optimizeField;
			}
			set
			{
				this.optimizeField = value;
			}
		}

		
		public bool OptimizeSpecified
		{
			get
			{
				return this.optimizeFieldSpecified;
			}
			set
			{
				this.optimizeFieldSpecified = value;
			}
		}

		
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

		public string AppDesignerFolder
		{
			get
			{
				return this.appDesignerFolderField;
			}
			set
			{
				this.appDesignerFolderField = value;
			}
		}
		
		public string DefineConstants
		{
			get
			{
				return this.defineConstantsField;
			}
			set
			{
				this.defineConstantsField = value;
			}
		}

		
		public string ErrorReport
		{
			get
			{
				return this.errorReportField;
			}
			set
			{
				this.errorReportField = value;
			}
		}

		
		public byte WarningLevel
		{
			get
			{
				return this.warningLevelField;
			}
			set
			{
				this.warningLevelField = value;
			}
		}

		
		public bool WarningLevelSpecified
		{
			get
			{
				return this.warningLevelFieldSpecified;
			}
			set
			{
				this.warningLevelFieldSpecified = value;
			}
		}

		
		public bool ConsolePause
		{
			get
			{
				return this.consolePauseField;
			}
			set
			{
				this.consolePauseField = value;
			}
		}

		
		public bool ConsolePauseSpecified
		{
			get
			{
				return this.consolePauseFieldSpecified;
			}
			set
			{
				this.consolePauseFieldSpecified = value;
			}
		}

		
		public bool AllowUnsafeBlocks
		{
			get
			{
				return this.allowUnsafeBlocksField;
			}
			set
			{
				this.allowUnsafeBlocksField = value;
			}
		}

		
		public bool AllowUnsafeBlocksSpecified
		{
			get
			{
				return this.allowUnsafeBlocksFieldSpecified;
			}
			set
			{
				this.allowUnsafeBlocksFieldSpecified = value;
			}
		}

		
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

		
		public string ProjectTypeGuids
		{
			get
			{
				return this.projectTypeGuidsField;
			}
			set
			{
				this.projectTypeGuidsField = value;
			}
		}

		
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

		
		public string OutputType
		{
			get
			{
				return this.outputTypeField;
			}
			set
			{
				this.outputTypeField = value;
			}
		}

		
		public string RootNamespace
		{
			get
			{
				return this.rootNamespaceField;
			}
			set
			{
				this.rootNamespaceField = value;
			}
		}

		
		public string IPhoneResourcePrefix
		{
			get
			{
				return this.iPhoneResourcePrefixField;
			}
			set
			{
				this.iPhoneResourcePrefixField = value;
			}
		}

		
		public string AssemblyName
		{
			get
			{
				return this.assemblyNameField;
			}
			set
			{
				this.assemblyNameField = value;
			}
		}

		
		public string TargetFrameworkIdentifier
		{
			get
			{
				return this.targetFrameworkIdentifierField;
			}
			set
			{
				this.targetFrameworkIdentifierField = value;
			}
		}

		
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
		public string TargetFrameworkVersion
		{
			get
			{
				return this.targetFrameworkVersionField;
			}
			set
			{
				this.targetFrameworkVersionField = value;
			}
		}

		/// <remarks/>
		public string TargetFrameworkProfile
		{
			get
			{
				return this.targetFrameworkProfileField;
			}
			set
			{
				this.targetFrameworkProfileField = value;
			}
		}


		/// <remarks/>
		public ushort FileAlignment
		{
			get
			{
				return this.fileAlignmentField;
			}
			set
			{
				this.fileAlignmentField = value;
			}
		}

		/// <remarks/>
		public bool FileAlignmentSpecified
		{
			get
			{
				return this.fileAlignmentFieldSpecified;
			}
			set
			{
				this.fileAlignmentFieldSpecified = value;
			}
		}

		public string PostBuildEvent
		{
			get
			{
				return this.postBuildEventField;
			}
			set
			{
				this.postBuildEventField = value;
			}
		}


		/// <remarks/>
		public string PlatformTarget
		{
			get
			{
				return this.platformTargetField;
			}
			set
			{
				this.platformTargetField = value;
			}
		}


		/// <remarks/>
		public ProjectPropertyGroupCustomCommands CustomCommands
		{
			get
			{
				return this.customCommandsField;
			}
			set
			{
				this.customCommandsField = value;
			}
		}













		/// <remarks/>
		public bool AndroidApplication
		{
			get
			{
				return this.androidApplicationField;
			}
			set
			{
				this.androidApplicationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool AndroidApplicationSpecified
		{
			get
			{
				return this.androidApplicationFieldSpecified;
			}
			set
			{
				this.androidApplicationFieldSpecified = value;
			}
		}

		/// <remarks/>
		public string AndroidResgenFile
		{
			get
			{
				return this.androidResgenFileField;
			}
			set
			{
				this.androidResgenFileField = value;
			}
		}

		/// <remarks/>
		public string GenerateSerializationAssemblies
		{
			get
			{
				return this.generateSerializationAssembliesField;
			}
			set
			{
				this.generateSerializationAssembliesField = value;
			}
		}

		/// <remarks/>
		public string AndroidManifest
		{
			get
			{
				return this.androidManifestField;
			}
			set
			{
				this.androidManifestField = value;
			}
		}

		/// <remarks/>
		public string AndroidUseSharedRuntime
		{
			get
			{
				return this.androidUseSharedRuntimeField;
			}
			set
			{
				this.androidUseSharedRuntimeField = value;
			}
		}

		/// <remarks/>
		public string AndroidLinkMode
		{
			get
			{
				return this.androidLinkModeField;
			}
			set
			{
				this.androidLinkModeField = value;
			}
		}

	
	
	
	}

}
