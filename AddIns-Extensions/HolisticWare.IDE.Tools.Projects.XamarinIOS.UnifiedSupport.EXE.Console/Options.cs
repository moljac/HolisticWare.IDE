using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommandLine;
using CommandLine.Text;

namespace Xamarin.iOS.UnifiedSupportTransformer
{
	public partial class UnifiedSupportTransformerCommandLineOptions
	{
		[ParserState]
		public IParserState LastParserState { get; set; }

		[HelpOption]
		public string GetUsage()
		{
			return HelpText.AutoBuild(this,
			  (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
		}

		[Option('i', "input", Required = false, HelpText = "Input csproj file[s] or folder containing csproj files")]
		public string Input { get; set; }

		[Option('o', "output", Required = false, HelpText = "Folder which will contain transformed csproj files")]
		public string Output { get; set; }

	}
}
