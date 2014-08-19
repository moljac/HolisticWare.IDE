using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{

			var types = new Type[]
				{
				  typeof(System.String)
				, typeof(System.Char)
				};


			//var methods = 
			//		from t in types
			//			where t.IsPublic && !t.IsSealed && t.IsClass
			//			where 
			//			(
			//				from method in t.GetMethods()
			//					select 
			//						new 
			//						{
			//							method 
			//						}
			//			).Count() > 0
			//			select t;


			var methods_public =
						(
							from t in
										(
											new Type[]
												{
												  typeof(System.String)
												, typeof(System.Char)
												}
										)
								select
									t.GetMethods
										(
										  System.Reflection.BindingFlags.Public
										  |
										  System.Reflection.BindingFlags.Instance
										)
						).SelectMany(o => o)
						;

			return;
		}
	}
}
