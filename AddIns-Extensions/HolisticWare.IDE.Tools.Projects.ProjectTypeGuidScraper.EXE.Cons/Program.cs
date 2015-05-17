using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HolisticWare.IDE.Tools.Projects.DomainBusinessLogic;

namespace HolisticWare.IDE.Tools.Projects.ProjectTypeGuidScraper.EXE
{
	class Program
	{
		static void Main(string[] args)
		{
			ProjectTypes projecttypes = ProjectTypes.GetProjectTypes();


			SerializationWarmUp();

			// Directory("*.*proj")
			//	*.csproj
			//	*.fsproj
			//	*.vbproj
			//	*.cxproj
			//	?????
			Project project = new Project();


			string[] files = null;
			string searchPattern = "*proj";

			string path = System.IO.Path.Combine("..", "..", "..", "..", "Templates", "Projects");
			files = System.IO.Directory.GetFiles(path, searchPattern, System.IO.SearchOption.AllDirectories);


			files_with_errors = new List<string>();

			nodes_unknown_total = new Dictionary<string, List<string>>();

			foreach(string f in files)
			{
				nodes_unknown = null;

				ReadProjectAsync(f);

				if (null != nodes_unknown)
				{
					nodes_unknown_total.Add(f, nodes_unknown);
				}
			}

			if (nodes_unknown_total.Keys.Count > 0)
			{
				throw new System.SystemException("Project with unknown node found!");
			}

			return;
		}


		static List<string> files_with_errors = null;

		
		
		
		private static void SerializationWarmUp()
		{
			System.Collections.Hashtable serializers = null;

			serializers = new System.Collections.Hashtable();

			// Use the constructor that takes a type and XmlRootAttribute.
			System.Xml.Serialization.XmlSerializer s = null;

			//s = new System.Xml.Serialization.XmlSerializer(typeof(Project), myRoot);

			// Implement a method named GenerateKey that creates unique keys 
			// for each instance of the XmlSerializer. The code should take 
			// into account all parameters passed to the XmlSerializer 
			// constructor.
			//object key = GenerateKey(typeof(Project), myRoot);

			// Check the local cache for a matching serializer.
			System.Xml.Serialization.XmlSerializer ser = null;
			//ser = (System.Xml.Serialization.XmlSerializer)serializers[key];

			if (ser == null)
			{
				//ser = new System.Xml.Serialization.XmlSerializer(typeof(Project), myRoot);
				// Cache the serializer.
				//serializers[key] = ser;
			}
			else
			{
				// Use the serializer to serialize, or deserialize.
			}
		}



		static async protected void ReadProjectAsync(string filename)
		{
			System.Console.WriteLine("projectname = {0}", filename);
				 

			// Create an instance of the XmlSerializer class; 
			// specify the type of object to be deserialized.
			System.Xml.Serialization.XmlSerializer serializer = null;
			serializer = new System.Xml.Serialization.XmlSerializer(typeof(Project));
			/* If the XML document has been altered with unknown 
			nodes or attributes, handle them with the 
			UnknownNode and UnknownAttribute events.*/
			serializer.UnknownNode += 
				new System.Xml.Serialization.XmlNodeEventHandler(serializer_UnknownNode)
				;
			serializer.UnknownAttribute += 
				new System.Xml.Serialization.XmlAttributeEventHandler(serializer_UnknownAttribute)
				;

			// A FileStream is needed to read the XML document.
			System.IO.FileStream fs = new System.IO.FileStream
														(
														filename, 
														System.IO.FileMode.Open,
														System.IO.FileAccess.Read,
														System.IO.FileShare.Read, 
														4096,
														useAsync: true
														);
			// Use the Deserialize method to restore the object's state with
			// data from the XML document.
			try
			{
				using (System.IO.StreamReader reader = new System.IO.StreamReader(fs))
				{
					string project_file_content = await reader.ReadToEndAsync();
					System.Console.WriteLine("\t project file content = ");
					System.Console.WriteLine(project_file_content);
				}


				// Declare an object variable of the type to be deserialized.
				Project po = (Project)serializer.Deserialize(fs);
			}
			catch (System.InvalidOperationException exc_inv_op)
			{
				files_with_errors.Add(filename);
			}
			catch (System.Exception exc)
			{
				throw exc;
			}

			return;
		}

		static private void serializer_UnknownAttribute(object sender, System.Xml.Serialization.XmlAttributeEventArgs e)
		{

			return;
		}

		static Dictionary<string, List<string>> nodes_unknown_total = null;
		static List<string> nodes_unknown = null;
		static private void serializer_UnknownNode(object sender, System.Xml.Serialization.XmlNodeEventArgs e)
		{
			System.Xml.Serialization.XmlSerializer s = null;			
			s = (System.Xml.Serialization.XmlSerializer) sender;

			if (null == nodes_unknown)
			{
				nodes_unknown = new List<string>();
			}


			nodes_unknown.Add(e.LocalName);

			return;
		}



	}
}
