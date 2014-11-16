using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Text.RegularExpressions;
using System.Xml;


namespace HolisticWare.IDE.Tools.Projects.XamarinIOS.UnifiedSupport
{
	public partial class UnifiedSupportTransformer
	{
		string source_folder = null;
		string destination_folder = null;

		ProjectTypes project_types = ProjectTypes.GetProjectTypes();
		public void TransformOriginalsToDestination (string input, string output)
		{
			if (null == input || "" == input)
			{
				input = source_folder = "originals";
			}

			if (null == output || "" == output)
			{
				output = destination_folder = "transformed";
			}

			// file attributes for file or directory
			FileAttributes attr_input = File.GetAttributes (input);
			FileAttributes attr_output = File.GetAttributes (output);

			bool input_is_file = (attr_input & FileAttributes.Normal) == FileAttributes.Normal;
			bool output_is_file = (attr_output & FileAttributes.Normal) == FileAttributes.Normal;

			bool input_is_folder = (attr_input & FileAttributes.Directory) == FileAttributes.Directory;
			bool output_is_folder = (attr_output & FileAttributes.Directory) == FileAttributes.Directory;

			if (output_is_file)
			{
				Console.Error.WriteLine (@"Error: output ''{0}'' must be a folder!", output);
				Console.Error.WriteLine("Error: output must be a folder!");

				return;

			}

			if (input_is_file)
			{
				string [] csprojs = null;

				csprojs = new string[] 
				{
					input
				};			
				CopyProjects(csprojs, output);

				csprojs = Directory.GetFiles(output, "*.csproj", SearchOption.TopDirectoryOnly);
				TransformProjectsUnified(csprojs);
				TransformProjectsClassic(csprojs);

			}
			else if (input_is_folder && output_is_folder)
			{				
				string [] csprojs = null;

				csprojs = Directory.GetFiles(input, "*.csproj", SearchOption.TopDirectoryOnly);
				CopyProjects(csprojs, output);

				csprojs = Directory.GetFiles(output, "*.csproj", SearchOption.TopDirectoryOnly);
				TransformProjectsUnified(csprojs);
				TransformProjectsClassic(csprojs);
			}
			else
			{
				// no args, defauult
				//		./originals/*.csproj
				//		./transformed/*.csproj

				string[] csprojs = ProjectFiles(source_folder);
				CopyProjects(csprojs, output);

			}

			return;
		}




		public void TransformProjectsUnified(string[] csprojs)
		{
			foreach (string csproj_unified in csprojs)
			{
				// stupid
				if (csproj_unified.Contains("-Classic.csproj"))
				{
					continue;
				};

				string csproj_unified_content = "";
				using (TextReader reader = File.OpenText(csproj_unified))
				{
					csproj_unified_content = reader.ReadToEnd();
				}

				Console.WriteLine (@"file = " + csproj_unified);
				XmlDocument doc = ContentTransformUnified (csproj_unified_content);

				//doc.Save(Console.Out);
				doc.Save(csproj_unified);
			}

			return;
		}

		public void TransformProjectsClassic(string[] csprojs)
		{
			foreach (string csproj_classic in csprojs)
			{
				// stupid
				if ( ! csproj_classic.Contains("-Classic.csproj"))
				{
					continue;
				};

				string csproj_classic_content = "";
				using (TextReader reader = File.OpenText(csproj_classic))
				{
					csproj_classic_content = reader.ReadToEnd();
				}
					
				Console.WriteLine (@"file = " + csproj_classic);
				XmlDocument doc = ContentTransformClassic (csproj_classic_content);

				doc.Save(Console.Out);
				doc.Save(csproj_classic);
			}

			return;
		}

		public XmlDocument ContentTransformUnified (string csproj_unified_content)
		{
			XmlDocument doc = new XmlDocument ();
			doc.LoadXml (csproj_unified_content);
			// needed to supress empty xmlns="" when adding nodes
			XmlNamespaceManager ns = new XmlNamespaceManager (doc.NameTable);
			string xmlns_dummy = "http://schemas.microsoft.com/developer/msbuild/2003";
			ns.AddNamespace ("x", xmlns_dummy);
			XmlNode root = doc.DocumentElement;
			//---------------------------------------------------------------------
			XmlNodeList project_guids = doc.GetElementsByTagName ("ProjectGuid");
			XmlNode node_project_guid = project_guids [0];
			Guid guid = Guid.NewGuid ();
			string guid_txt = guid.ToString ();
			node_project_guid.InnerText = "{" + guid_txt.ToUpper () + "}";
			//---------------------------------------------------------------------
			//---------------------------------------------------------------------
			XmlNodeList project_type_guids = doc.GetElementsByTagName ("ProjectTypeGuids");
			XmlNode node_type_project_guid = project_type_guids [0];
			if (node_type_project_guid.InnerText.Contains ("{FEACFBD2-3405-455C-9665-78FE426C6842}"))
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine (@"\t\t ProjectTypeGuids = iOS Unified Library / App");
			}
			else if (node_type_project_guid.InnerText.Contains ("{F5B4F3BC-B597-4E2B-B552-EF5D8A32436F}"))
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine (@"\t\t ProjectTypeGuids = iOS Binding (Classic & Unified)");
				node_type_project_guid.InnerText = "{FEACFBD2-3405-455C-9665-78FE426C6842};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}";
			}
			else if (node_type_project_guid.InnerText.Contains ("{EE2C853D-36AF-4FDB-B1AD-8E90477E2198}"))
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine (@"\t\t ProjectTypeGuids = iOS Unified App Extension");
			}
			else if (node_type_project_guid.InnerText.Contains ("{FEACFBD2-3405-455C-9665-78FE426C6842};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}"))
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine (@"\t\t ProjectTypeGuids = Already Converted");
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine (@"\t\t Unknown ProjectTypeGuids = " + node_type_project_guid.InnerText);
				node_type_project_guid.InnerText = "{FEACFBD2-3405-455C-9665-78FE426C6842};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}";
			}
			Console.ResetColor ();
			//---------------------------------------------------------------------
			//---------------------------------------------------------------------
			XmlNodeList references = doc.GetElementsByTagName ("Reference");
			for (int i = 0; i < references.Count; i++)
			{
				XmlNode node = references [i];
				XmlAttribute attribute_include = node.Attributes ["Include"];
				if (attribute_include.InnerText == "monotouch")
				{
					attribute_include.InnerText = "Xamarin.iOS";
				}
			}
			//---------------------------------------------------------------------
			//---------------------------------------------------------------------
			XmlNodeList target_import = doc.GetElementsByTagName ("Import");
			XmlNode node_target_import = target_import [0];
			node_target_import.Attributes ["Project"].InnerText = @"$(MSBuildExtensionsPath)\Xamarin\iOS\Xamarin.iOS.CSharp.targets";
			//---------------------------------------------------------------------
			//---------------------------------------------------------------------
			XmlNodeList project_preprocessor = doc.GetElementsByTagName ("DefineConstants");
			XmlNode node_project_preprocessor = project_preprocessor [0];
			node_project_preprocessor.InnerText = node_project_preprocessor.InnerText + "__UNIFIED__;";
			//---------------------------------------------------------------------
			//---------------------------------------------------------------------
			//string xpath = @"/Project/PropertyGroup[@Condition]";
			XmlNodeList property_groups = doc.GetElementsByTagName ("PropertyGroup");
			for (int i = 0; i < property_groups.Count; i++)
			{
				XmlNode n = property_groups [i];
				XmlAttribute xa = n.Attributes ["Condition"];

				string configuration_platform = null;

				if (null != xa)
				{
					configuration_platform = xa.InnerText;
					string configuration = null;
					string platform = null;

					string[] configurations =
						new[]
						{
							"Debug"
						,	"Release"
						};
					foreach (string s in configurations)
					{
						if (configuration_platform.Contains(s))
						{
							configuration = s;
						}
					}

					string[] platforms =
						new[]
						{
							"AnyCPU"
						,	"iPhone"
						,	"iPhoneSimulator"
						,	"AppStore"
						,	"Ad-Hoc"
						,	"AdHoc"
						};

					foreach (string s in platforms)
					{
						if (configuration_platform.Contains(s))
						{
							platform = s;
						}
					}

					string node_name = "";
					XmlElement elem = null;

					string ios_api = "unified";

					// http://msdn.microsoft.com/en-us/library/bb629394.aspx
					//......................................................
					// Specifies the path to the output directory, relative to the project 
					// directory, for example, "bin\Debug".
					node_name = "OutputPath";
					elem = doc.CreateElement(node_name, xmlns_dummy);
					elem.InnerText =
								//@"bin\classic\%24%28Platform%29\%24%28Configuration%29\"
								@"bin\" + ios_api + @"\" + platform + @"\" + configuration
								;
					//Add the node to the document.
					n.InsertAfter(elem, n.LastChild);
					//......................................................

					//......................................................
					// The top-level folder where all configuration-specific intermediate output 
					// folders are created. The default value is obj\. 
					// The following code is an example: 
					// <BaseIntermediateOutputPath>c:\xyz\obj\</BaseIntermediateOutputPath>

					node_name = "BaseIntermediateOutputPath";
					elem = doc.CreateElement(node_name, xmlns_dummy);
					elem.InnerText = @"obj\" + ios_api + @"\";
					//Add the node to the document.
					n.InsertAfter(elem, n.LastChild);
					//......................................................
					//......................................................
					// The full intermediate output path as derived from BaseIntermediateOutputPath, 
					// if no path is specified. For example, \obj\debug\. If this property is overridden, 
					// then setting BaseIntermediateOutputPath has no effect.
					node_name = "IntermediateOutputPath";
					elem = doc.CreateElement(node_name, xmlns_dummy);
					elem.InnerText =
								//@"obj\classic\%24%28Platform%29\%24%28Configuration%29\"
								@"obj\" + ios_api + @"\" + platform + @"\" + configuration;
								;
					//Add the node to the document.
					n.InsertAfter(elem, n.LastChild);
					//......................................................					
				}
			}
			//---------------------------------------------------------------------

			return doc;
		}

		public XmlDocument ContentTransformClassic (string csproj_classic_content)
		{
			XmlDocument doc = new XmlDocument ();
			doc.LoadXml (csproj_classic_content);
			// needed to supress empty xmlns="" when adding nodes
			XmlNamespaceManager ns = new XmlNamespaceManager (doc.NameTable);
			string xmlns_dummy = "http://schemas.microsoft.com/developer/msbuild/2003";
			ns.AddNamespace ("x", xmlns_dummy);
			XmlNode root = doc.DocumentElement;
			//---------------------------------------------------------------------
			//string xpath = @"/Project/PropertyGroup[@Condition]";
			XmlNodeList property_groups = doc.GetElementsByTagName ("PropertyGroup");
			for (int i = 0; i < property_groups.Count; i++)
			{
				XmlNode n = property_groups [i];
				XmlAttribute xa = n.Attributes ["Condition"];

				string configuration_platform = null;

				if (null != xa)
				{
					configuration_platform = xa.InnerText;
					string configuration = null;
					string platform = null;

					string[] configurations =
						new[]
						{
							"Debug"
						,	"Release"
						};
					foreach (string s in configurations)
					{
						if (configuration_platform.Contains(s))
						{
							configuration = s;
						}
					}

					string[] platforms =
						new[]
						{
							"AnyCPU"
						,	"iPhone"
						,	"iPhoneSimulator"
						,	"AppStore"
						,	"Ad-Hoc"
						,	"AdHoc"
						};

					foreach (string s in platforms)
					{
						if (configuration_platform.Contains(s))
						{
							platform = s;
						}
					}

					string node_name = "";
					XmlElement elem = null;

					string ios_api = "classic";

					// http://msdn.microsoft.com/en-us/library/bb629394.aspx
					//......................................................
					// Specifies the path to the output directory, relative to the project 
					// directory, for example, "bin\Debug".
					node_name = "OutputPath";
					elem = doc.CreateElement (node_name, xmlns_dummy);
					elem.InnerText =
								//@"bin\classic\%24%28Platform%29\%24%28Configuration%29\"
								@"bin\" +  ios_api + @"\" + platform + @"\" + configuration
								;
					//Add the node to the document.
					n.InsertAfter (elem, n.LastChild);
					//......................................................

					//......................................................
					// The top-level folder where all configuration-specific intermediate output 
					// folders are created. The default value is obj\. 
					// The following code is an example: 
					// <BaseIntermediateOutputPath>c:\xyz\obj\</BaseIntermediateOutputPath>

					node_name = "BaseIntermediateOutputPath";
					elem = doc.CreateElement (node_name, xmlns_dummy);
					elem.InnerText = @"obj\" + ios_api + @"\";
					//Add the node to the document.
					n.InsertAfter (elem, n.LastChild);
					//......................................................
					//......................................................
					// The full intermediate output path as derived from BaseIntermediateOutputPath, 
					// if no path is specified. For example, \obj\debug\. If this property is overridden, 
					// then setting BaseIntermediateOutputPath has no effect.
					node_name = "IntermediateOutputPath";
					elem = doc.CreateElement(node_name, xmlns_dummy);
					elem.InnerText =
								//@"obj\classic\%24%28Platform%29\%24%28Configuration%29\"
								@"obj\" + ios_api + @"\" + platform + @"\" + configuration;
								;
					//Add the node to the document.
					n.InsertAfter(elem, n.LastChild);
					//......................................................					
				}
			}
			//---------------------------------------------------------------------

			return doc;
		}

		public string XmlDocumentToString (XmlDocument doc)
		{
			string content = null;

			using (StringWriter stringWriter = new StringWriter ())
				using (XmlWriter xmlTextWriter = XmlWriter.Create (stringWriter))
				{
					doc.WriteTo (xmlTextWriter);
					xmlTextWriter.Flush ();
					content = stringWriter.GetStringBuilder ().ToString ();
				}

			return content;
		}


		public string[] ProjectFiles(string source_folder)
		{
			string [] fileEntries = Directory.GetFiles(source_folder, "*.csproj", SearchOption.TopDirectoryOnly);
 
			return fileEntries;
		}

		public string[] CopyProjects(string[] files, string destination_folder)
		{
			List<string> projects_transformed = new List<string>();

			foreach(string file_csproj in files)
			{
				string file_csproj_wo_path = file_csproj
												.Replace(source_folder + Path.DirectorySeparatorChar, "");


				string file_csproj_bckp = file_csproj_wo_path
												.Replace(".csproj", ".csproj.bckp")
												;
				string file_csproj_classic = file_csproj_wo_path
												.Replace(".csproj", "-Classic.csproj")
												;
				string file_csproj_unified = file_csproj_wo_path;

				//Console.WriteLine("file_csproj			= {0}", file_csproj);
				//Console.WriteLine("file_csproj_bckp		= {0}", file_csproj_bckp);
				//Console.WriteLine("file_csproj_classic	= {0}", file_csproj_classic);
				//Console.WriteLine("file_csproj_unified	= {0}", file_csproj_unified);

				File.Copy
						(
						  file_csproj
					, Path.Combine(destination_folder, file_csproj_bckp)
						, true // overwrite
						);

				File.Copy
						(
						  file_csproj
						, Path.Combine(destination_folder, file_csproj_classic)
						, true // overwrite
						);

				File.Copy
						(
						  file_csproj
						, Path.Combine(destination_folder, file_csproj_unified)
						, true // overwrite
						);

			}

			return projects_transformed.ToArray();
		}

	}
}
