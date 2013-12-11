//=========================================================================
/*
 * Trick from Enterprise Library for .NET 2.0 used to write unit tests for both 
 * NUnit and VS UT
*/
# define NUNIT
//# define NTIME

#if !NUNIT
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
using TestFixtureSetUp = Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute;
#else
using NUnit.Framework;
using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestInitialize = NUnit.Framework.SetUpAttribute;
using TestCleanup = NUnit.Framework.TearDownAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
#endif
#if NTIME
	using NTime.Framework;
# else
//using TimerDurationTest = global::Core.DLL_00Development.TestAttribute;
# endif
//=========================================================================

using System;
using System.Text;
using System.Collections.Generic;

using System.Diagnostics;
using HolisticWare.IDE.AutomationTools.Snippets;


namespace UnitTests.HolisticWare.IDE.AutomationTools.Snippets
{
	/// <summary>
	/// Summary description for Task
	/// </summary>
	[TestClass]
	public
	  partial
	  class
	  SnippetManagerTests
#if SILVERLIGHT
	  : SilverlightTest
#endif
	{
		/// <summary>
		/// Constructor default
		/// </summary>
		public
		   SnippetManagerTests
		  (
		  )
		{
			SnippetManager snippet_manager = new SnippetManager();

			string[] visual_studio_versions = snippet_manager.VisualStudioVersionsInstalled();
			string[] xamarin_studio_versions = snippet_manager.XamarinStudioVersionsInstalled();

			return;
		}

		#region Additional test attributes
		//
		// You can use the following additional attributes as you write your tests:
		//
		// Use ClassInitialize to run code_class before running the first test in the class
		// [ClassInitialize()]
		// public static void MyClassInitialize(TestContext testContext) { }
		//
		// Use ClassCleanup to run code_class after all tests in a class have run
		// [ClassCleanup()]
		// public static void MyClassCleanup() { }
		//
		// Use TestInitialize to run code_class before running each test 
		// [TestInitialize()]
		// public void MyTestInitialize() { }
		//
		// Use TestCleanup to run code_class after each test has run
		// [TestCleanup()]
		// public void MyTestCleanup() { }
		//
		#endregion

		/// <summary>
		/// Swap test case
		/// </summary>
		[TestMethod]  //[TestMethod]
		public
		  void
		  Locations
		  (

		  )
		{

			return;
		}
	}
}
