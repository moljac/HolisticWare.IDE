﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.1.
// 
namespace HolisticWare.IDE.AutomationTools.Snippets.MonoDevelop {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class RazorCodeTemplates {
        
        private RazorCodeTemplatesCodeTemplate[] codeTemplateField;
        
        private decimal versionField;
        
        private bool versionFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CodeTemplate")]
        public RazorCodeTemplatesCodeTemplate[] CodeTemplate {
            get {
                return this.codeTemplateField;
            }
            set {
                this.codeTemplateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool versionSpecified {
            get {
                return this.versionFieldSpecified;
            }
            set {
                this.versionFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class RazorCodeTemplatesCodeTemplate {
        
        private RazorCodeTemplatesCodeTemplateHeader headerField;
        
        private RazorCodeTemplatesCodeTemplateVariables variablesField;
        
        private string codeField;
        
        private decimal versionField;
        
        private bool versionFieldSpecified;
        
        /// <remarks/>
        public RazorCodeTemplatesCodeTemplateHeader Header {
            get {
                return this.headerField;
            }
            set {
                this.headerField = value;
            }
        }
        
        /// <remarks/>
        public RazorCodeTemplatesCodeTemplateVariables Variables {
            get {
                return this.variablesField;
            }
            set {
                this.variablesField = value;
            }
        }
        
        /// <remarks/>
        public string Code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool versionSpecified {
            get {
                return this.versionFieldSpecified;
            }
            set {
                this.versionFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class RazorCodeTemplatesCodeTemplateHeader {
        
        private string _GroupField;
        
        private decimal versionField;
        
        private string mimeTypeField;
        
        private string shortcutField;
        
        private string _DescriptionField;
        
        private string templateTypeField;
        
        /// <remarks/>
        public string _Group {
            get {
                return this._GroupField;
            }
            set {
                this._GroupField = value;
            }
        }
        
        /// <remarks/>
        public decimal Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        public string MimeType {
            get {
                return this.mimeTypeField;
            }
            set {
                this.mimeTypeField = value;
            }
        }
        
        /// <remarks/>
        public string Shortcut {
            get {
                return this.shortcutField;
            }
            set {
                this.shortcutField = value;
            }
        }
        
        /// <remarks/>
        public string _Description {
            get {
                return this._DescriptionField;
            }
            set {
                this._DescriptionField = value;
            }
        }
        
        /// <remarks/>
        public string TemplateType {
            get {
                return this.templateTypeField;
            }
            set {
                this.templateTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class RazorCodeTemplatesCodeTemplateVariables {
        
        private RazorCodeTemplatesCodeTemplateVariablesVariable variableField;
        
        /// <remarks/>
        public RazorCodeTemplatesCodeTemplateVariablesVariable Variable {
            get {
                return this.variableField;
            }
            set {
                this.variableField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class RazorCodeTemplatesCodeTemplateVariablesVariable {
        
        private string defaultField;
        
        private string _ToolTipField;
        
        private string nameField;
        
        /// <remarks/>
        public string Default {
            get {
                return this.defaultField;
            }
            set {
                this.defaultField = value;
            }
        }
        
        /// <remarks/>
        public string _ToolTip {
            get {
                return this._ToolTipField;
            }
            set {
                this._ToolTipField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
}
