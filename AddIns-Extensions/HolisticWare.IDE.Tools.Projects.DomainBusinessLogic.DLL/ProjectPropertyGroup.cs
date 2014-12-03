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

		private decimal minimumVisualStudioVersionField;

		private bool minimumVisualStudioVersionFieldSpecified;

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

		private bool javaOptionsSpecified;

		private bool mtouchDebugField;

		private bool mtouchDebugFieldSpecified;

		private string mtouchLinkField;

		private string codesignKeyField;

		private string buildIpaField;

		private string silverlightVersionField;

		private bool silverlightApplicationField;

		private bool silverlightApplicationFieldSpecified;

		private object supportedCulturesField;

		private bool xapOutputsField;

		private bool xapOutputsFieldSpecified;

		private bool generateSilverlightManifestField;

		private bool generateSilverlightManifestFieldSpecified;

		private string xapFilenameField;

		private string silverlightManifestTemplateField;

		private string silverlightAppEntryField;

		private bool validateXamlField;

		private bool validateXamlFieldSpecified;

		private bool throwErrorsInValidationField;

		private bool throwErrorsInValidationFieldSpecified;

		private bool noStdLibField;

		private bool noStdLibFieldSpecified;

		private bool noConfigField;

		private bool noConfigFieldSpecified;

		

		// Xamarin.Studio / Monodevelop c/c++ projects
		private ProjectPropertyGroupCompiler compilerField;






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


		/// <remarks/>
		public decimal MinimumVisualStudioVersion
		{
			get
			{
				return this.minimumVisualStudioVersionField;
			}
			set
			{
				this.minimumVisualStudioVersionField = value;
			}
		}

		/// <remarks/>
		public bool MinimumVisualStudioVersionSpecified
		{
			get
			{
				return this.minimumVisualStudioVersionFieldSpecified;
			}
			set
			{
				this.minimumVisualStudioVersionFieldSpecified = value;
			}
		}


		object androidUseLatestPlatformSdk;
		/// <remarks/>
		public object AndroidUseLatestPlatformSdk
		{
			get
			{
				return this.androidUseLatestPlatformSdk;
			}
			set
			{
				this.androidUseLatestPlatformSdk = value;
			}
		}

		bool androidUseLatestPlatformSdkSpecified;
		/// <remarks/>
		public bool AndroidUseLatestPlatformSdkSpecified
		{
			get
			{
				return this.androidUseLatestPlatformSdkSpecified;
			}
			set
			{
				this.androidUseLatestPlatformSdkSpecified = value;
			}
		}



		string androidSupportedAbis;
		/// <remarks/>
		public string AndroidSupportedAbis
		{
			get
			{
				return this.androidSupportedAbis;
			}
			set
			{
				this.androidSupportedAbis = value;
			}
		}

		bool androidSupportedAbisSpecified;
		/// <remarks/>
		public bool AndroidSupportedAbisSpecified
		{
			get
			{
				return this.androidSupportedAbisSpecified;
			}
			set
			{
				this.androidSupportedAbisSpecified = value;
			}
		}



		object androidStoreUncompressedFileExtensions;
		/// <remarks/>
		public object AndroidStoreUncompressedFileExtensions
		{
			get
			{
				return this.androidStoreUncompressedFileExtensions;
			}
			set
			{
				this.androidStoreUncompressedFileExtensions = value;
			}
		}

		bool androidStoreUncompressedFileExtensionsSpecified;
		/// <remarks/>
		public bool AndroidStoreUncompressedFileExtensionsSpecified
		{
			get
			{
				return this.androidStoreUncompressedFileExtensionsSpecified;
			}
			set
			{
				this.androidStoreUncompressedFileExtensionsSpecified = value;
			}
		}




		object mandroidI18n;
		/// <remarks/>
		public object MandroidI18n
		{
			get
			{
				return this.mandroidI18n;
			}
			set
			{
				this.mandroidI18n = value;
			}
		}

		bool mandroidI18nSpecified;
		/// <remarks/>
		public bool MandroidI18nSpecified
		{
			get
			{
				return this.mandroidI18nSpecified;
			}
			set
			{
				this.mandroidI18nSpecified = value;
			}
		}




		long javaMaximumHeapSize;
		/// <remarks/>
		public long JavaMaximumHeapSize
		{
			get
			{
				return this.JavaMaximumHeapSize;
			}
			set
			{
				this.JavaMaximumHeapSize = value;
			}
		}

		bool javaMaximumHeapSizeSpecified;
		/// <remarks/>
		public bool JavaMaximumHeapSizeSpecified
		{
			get
			{
				return this.javaMaximumHeapSizeSpecified;
			}
			set
			{
				this.javaMaximumHeapSizeSpecified = value;
			}
		}



		string javaOptions;
		/// <remarks/>
		public string JavaOptions
		{
			get
			{
				return this.javaOptions;
			}
			set
			{
				this.javaOptions = value;
			}
		}

		/// <remarks/>
		public bool JavaOptionsSpecified
		{
			get
			{
				return this.javaOptionsSpecified;
			}
			set
			{
				this.javaOptionsSpecified = value;
			}
		}






		/// <remarks/>
		public string MtouchLink
		{
			get
			{
				return this.mtouchLinkField;
			}
			set
			{
				this.mtouchLinkField = value;
			}
		}

		/// <remarks/>
		public bool MtouchDebug
		{
			get
			{
				return this.mtouchDebugField;
			}
			set
			{
				this.mtouchDebugField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool MtouchDebugSpecified
		{
			get
			{
				return this.mtouchDebugFieldSpecified;
			}
			set
			{
				this.mtouchDebugFieldSpecified = value;
			}
		}

		/// <remarks/>
		public string CodesignKey
		{
			get
			{
				return this.codesignKeyField;
			}
			set
			{
				this.codesignKeyField = value;
			}
		}

		/// <remarks/>
		public string BuildIpa
		{
			get
			{
				return this.buildIpaField;
			}
			set
			{
				this.buildIpaField = value;
			}
		}












		/// <remarks/>
		public string SilverlightVersion
		{
			get
			{
				return this.silverlightVersionField;
			}
			set
			{
				this.silverlightVersionField = value;
			}
		}

		/// <remarks/>
		public bool SilverlightApplication
		{
			get
			{
				return this.silverlightApplicationField;
			}
			set
			{
				this.silverlightApplicationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool SilverlightApplicationSpecified
		{
			get
			{
				return this.silverlightApplicationFieldSpecified;
			}
			set
			{
				this.silverlightApplicationFieldSpecified = value;
			}
		}

		/// <remarks/>
		public object SupportedCultures
		{
			get
			{
				return this.supportedCulturesField;
			}
			set
			{
				this.supportedCulturesField = value;
			}
		}

		/// <remarks/>
		public bool XapOutputs
		{
			get
			{
				return this.xapOutputsField;
			}
			set
			{
				this.xapOutputsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool XapOutputsSpecified
		{
			get
			{
				return this.xapOutputsFieldSpecified;
			}
			set
			{
				this.xapOutputsFieldSpecified = value;
			}
		}

		/// <remarks/>
		public bool GenerateSilverlightManifest
		{
			get
			{
				return this.generateSilverlightManifestField;
			}
			set
			{
				this.generateSilverlightManifestField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool GenerateSilverlightManifestSpecified
		{
			get
			{
				return this.generateSilverlightManifestFieldSpecified;
			}
			set
			{
				this.generateSilverlightManifestFieldSpecified = value;
			}
		}

		/// <remarks/>
		public string XapFilename
		{
			get
			{
				return this.xapFilenameField;
			}
			set
			{
				this.xapFilenameField = value;
			}
		}

		/// <remarks/>
		public string SilverlightManifestTemplate
		{
			get
			{
				return this.silverlightManifestTemplateField;
			}
			set
			{
				this.silverlightManifestTemplateField = value;
			}
		}

		/// <remarks/>
		public string SilverlightAppEntry
		{
			get
			{
				return this.silverlightAppEntryField;
			}
			set
			{
				this.silverlightAppEntryField = value;
			}
		}

		/// <remarks/>
		public bool ValidateXaml
		{
			get
			{
				return this.validateXamlField;
			}
			set
			{
				this.validateXamlField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool ValidateXamlSpecified
		{
			get
			{
				return this.validateXamlFieldSpecified;
			}
			set
			{
				this.validateXamlFieldSpecified = value;
			}
		}



		/// <remarks/>
		public bool ThrowErrorsInValidation
		{
			get
			{
				return this.throwErrorsInValidationField;
			}
			set
			{
				this.throwErrorsInValidationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool ThrowErrorsInValidationSpecified
		{
			get
			{
				return this.throwErrorsInValidationFieldSpecified;
			}
			set
			{
				this.throwErrorsInValidationFieldSpecified = value;
			}
		}


		/// <remarks/>
		public bool NoStdLib
		{
			get
			{
				return this.noStdLibField;
			}
			set
			{
				this.noStdLibField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool NoStdLibSpecified
		{
			get
			{
				return this.noStdLibFieldSpecified;
			}
			set
			{
				this.noStdLibFieldSpecified = value;
			}
		}



		/// <remarks/>
		public bool NoConfig
		{
			get
			{
				return this.noConfigField;
			}
			set
			{
				this.noConfigField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool NoConfigSpecified
		{
			get
			{
				return this.noConfigFieldSpecified;
			}
			set
			{
				this.noConfigFieldSpecified = value;
			}
		}
















		// XS ASP.net app

		bool defineDebug;
		/// <remarks/>
		public bool DefineDebug
		{
			get
			{
				return this.defineDebug;
			}
			set
			{
				this.defineDebug = value;
			}
		}

		bool defineDebugSpecified;
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool DefineDebugSpecified
		{
			get
			{
				return this.defineDebugSpecified;
			}
			set
			{
				this.defineDebugSpecified = value;
			}
		}


		bool defineTrace;
		/// <remarks/>
		public bool DefineTrace
		{
			get
			{
				return this.defineTrace;
			}
			set
			{
				this.defineTrace = value;
			}
		}

		bool defineTraceSpecified;
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool DefineTraceSpecified
		{
			get
			{
				return this.defineTraceSpecified;
			}
			set
			{
				this.defineTraceSpecified = value;
			}
		}


		bool additionalParameters;
		/// <remarks/>
		public bool AdditionalParameters
		{
			get
			{
				return this.additionalParameters;
			}
			set
			{
				this.additionalParameters = value;
			}
		}

		bool additionalParametersSpecified;
		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool AdditionalParametersSpecified
		{
			get
			{
				return this.additionalParametersSpecified;
			}
			set
			{
				this.additionalParametersSpecified = value;
			}
		}
















		// SharedProjects

		private string labelField;
		private bool externalconsoleField;
		private bool externalconsoleFieldSpecified;
		private string outputNameField;
		private string compileTargetField;
		private byte optimizationLevelField;
		private bool optimizationLevelFieldSpecified;
		private string defineSymbolsField;
		private string sourceDirectoryField;
		private string languageField;
		private string targetField;
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Label
		{
			get
			{
				return this.labelField;
			}
			set
			{
				this.labelField = value;
			}
		}










		// Xamarin.Studio / MonoDevelop c/c++ projects
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







	}

}
