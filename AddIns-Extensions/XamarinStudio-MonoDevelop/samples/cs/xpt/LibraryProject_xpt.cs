﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.1.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class Options {
    
    private string startupProjectField;
    
    private string targetField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string StartupProject {
        get {
            return this.startupProjectField;
        }
        set {
            this.startupProjectField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Target {
        get {
            return this.targetField;
        }
        set {
            this.targetField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class Template {
    
    private string actionsField;
    
    private TemplateTemplateConfiguration[] templateConfigurationField;
    
    private TemplateCombine[] combineField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Actions {
        get {
            return this.actionsField;
        }
        set {
            this.actionsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TemplateConfiguration", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public TemplateTemplateConfiguration[] TemplateConfiguration {
        get {
            return this.templateConfigurationField;
        }
        set {
            this.templateConfigurationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Combine", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public TemplateCombine[] Combine {
        get {
            return this.combineField;
        }
        set {
            this.combineField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class TemplateTemplateConfiguration {
    
    private string _NameField;
    
    private string _CategoryField;
    
    private string iconField;
    
    private string languageNameField;
    
    private string _DescriptionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string _Name {
        get {
            return this._NameField;
        }
        set {
            this._NameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string _Category {
        get {
            return this._CategoryField;
        }
        set {
            this._CategoryField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Icon {
        get {
            return this.iconField;
        }
        set {
            this.iconField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string LanguageName {
        get {
            return this.languageNameField;
        }
        set {
            this.languageNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string _Description {
        get {
            return this._DescriptionField;
        }
        set {
            this._DescriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class TemplateCombine {
    
    private Options[] optionsField;
    
    private TemplateCombineProject[] projectField;
    
    private string nameField;
    
    private string directoryField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Options")]
    public Options[] Options {
        get {
            return this.optionsField;
        }
        set {
            this.optionsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Project", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public TemplateCombineProject[] Project {
        get {
            return this.projectField;
        }
        set {
            this.projectField = value;
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string directory {
        get {
            return this.directoryField;
        }
        set {
            this.directoryField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class TemplateCombineProject {
    
    private Options[] optionsField;
    
    private TemplateCombineProjectReferencesReference[][] referencesField;
    
    private TemplateCombineProjectFilesDirectory[][] filesField;
    
    private string nameField;
    
    private string directoryField;
    
    private string typeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Options")]
    public Options[] Options {
        get {
            return this.optionsField;
        }
        set {
            this.optionsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Reference", typeof(TemplateCombineProjectReferencesReference), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public TemplateCombineProjectReferencesReference[][] References {
        get {
            return this.referencesField;
        }
        set {
            this.referencesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Directory", typeof(TemplateCombineProjectFilesDirectory), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public TemplateCombineProjectFilesDirectory[][] Files {
        get {
            return this.filesField;
        }
        set {
            this.filesField = value;
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string directory {
        get {
            return this.directoryField;
        }
        set {
            this.directoryField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class TemplateCombineProjectReferencesReference {
    
    private string typeField;
    
    private string reftoField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string refto {
        get {
            return this.reftoField;
        }
        set {
            this.reftoField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class TemplateCombineProjectFilesDirectory {
    
    private string nameField;
    
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

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class NewDataSet {
    
    private object[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Options", typeof(Options))]
    [System.Xml.Serialization.XmlElementAttribute("Template", typeof(Template))]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}
