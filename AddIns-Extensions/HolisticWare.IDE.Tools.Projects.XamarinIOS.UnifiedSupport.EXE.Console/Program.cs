using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

namespace Xamarin.iOS.UnifiedSupportTransformer
{
	class Program
	{
		static void Main(string[] args)
		{
			var options = new UnifiedSupportTransformerCommandLineOptions();

			if (CommandLine.Parser.Default.ParseArguments(args, options))
			{
				Debug.WriteLine("Filename: {0}", options.Input);
				Debug.WriteLine("Filename: {0}", options.Output);
					
				UnifiedSupportTransformer ust = new UnifiedSupportTransformer();

				ust.TransformOriginalsToDestination(options.Input, options.Output);

			}

			return;
		}
	}
}
