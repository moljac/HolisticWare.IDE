using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolisticWare.IDE.Tools.Projects.DomainBusinessLogic
{
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public partial class ProjectProjectExtensionsMonoDevelopProperties
	{

		private ProjectProjectExtensionsMonoDevelopPropertiesXspParameters xspParametersField;

		private string verifyCodeBehindFieldsField;

		private string verifyCodeBehindEventsField;

		/// <remarks/>
		public ProjectProjectExtensionsMonoDevelopPropertiesXspParameters XspParameters
		{
			get
			{
				return this.xspParametersField;
			}
			set
			{
				this.xspParametersField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string VerifyCodeBehindFields
		{
			get
			{
				return this.verifyCodeBehindFieldsField;
			}
			set
			{
				this.verifyCodeBehindFieldsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string VerifyCodeBehindEvents
		{
			get
			{
				return this.verifyCodeBehindEventsField;
			}
			set
			{
				this.verifyCodeBehindEventsField = value;
			}
		}
	}
}
