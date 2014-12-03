using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolisticWare.IDE.Tools.Projects.DomainBusinessLogic
{
	/// <remarks/>
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public partial class ProjectProjectExtensionsMonoDevelopPropertiesXspParameters
	{

		private ushort portField;

		private string addressField;

		private string sslModeField;

		private string sslProtocolField;

		private string keyTypeField;

		private string certFileField;

		private string keyFileField;

		private string passwordOptionsField;

		private string passwordField;

		private string verboseField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public ushort Port
		{
			get
			{
				return this.portField;
			}
			set
			{
				this.portField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Address
		{
			get
			{
				return this.addressField;
			}
			set
			{
				this.addressField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string SslMode
		{
			get
			{
				return this.sslModeField;
			}
			set
			{
				this.sslModeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string SslProtocol
		{
			get
			{
				return this.sslProtocolField;
			}
			set
			{
				this.sslProtocolField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string KeyType
		{
			get
			{
				return this.keyTypeField;
			}
			set
			{
				this.keyTypeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string CertFile
		{
			get
			{
				return this.certFileField;
			}
			set
			{
				this.certFileField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string KeyFile
		{
			get
			{
				return this.keyFileField;
			}
			set
			{
				this.keyFileField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string PasswordOptions
		{
			get
			{
				return this.passwordOptionsField;
			}
			set
			{
				this.passwordOptionsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Password
		{
			get
			{
				return this.passwordField;
			}
			set
			{
				this.passwordField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Verbose
		{
			get
			{
				return this.verboseField;
			}
			set
			{
				this.verboseField = value;
			}
		}
	}
}
