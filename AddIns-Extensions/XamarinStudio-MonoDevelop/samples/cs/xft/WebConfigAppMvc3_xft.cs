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
public partial class Template {
    
    private TemplateTemplateConfiguration[] templateConfigurationField;
    
    private TemplateConditionsParentProject[][] conditionsField;
    
    private TemplateTemplateFilesAspNetFile[][] templateFilesField;
    
    private string originatorField;
    
    private string createdField;
    
    private string lastModifiedField;
    
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
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ParentProject", typeof(TemplateConditionsParentProject), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public TemplateConditionsParentProject[][] Conditions {
        get {
            return this.conditionsField;
        }
        set {
            this.conditionsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("AspNetFile", typeof(TemplateTemplateFilesAspNetFile), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public TemplateTemplateFilesAspNetFile[][] TemplateFiles {
        get {
            return this.templateFilesField;
        }
        set {
            this.templateFilesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Originator {
        get {
            return this.originatorField;
        }
        set {
            this.originatorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Created {
        get {
            return this.createdField;
        }
        set {
            this.createdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string LastModified {
        get {
            return this.lastModifiedField;
        }
        set {
            this.lastModifiedField = value;
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
    
    private string projectTypeField;
    
    private string _DescriptionField;
    
    private TemplateTemplateConfigurationDefaultFilename[] defaultFilenameField;
    
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
    public string ProjectType {
        get {
            return this.projectTypeField;
        }
        set {
            this.projectTypeField = value;
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DefaultFilename", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public TemplateTemplateConfigurationDefaultFilename[] DefaultFilename {
        get {
            return this.defaultFilenameField;
        }
        set {
            this.defaultFilenameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class TemplateTemplateConfigurationDefaultFilename {
    
    private string isFixedField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string IsFixed {
        get {
            return this.isFixedField;
        }
        set {
            this.isFixedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class TemplateConditionsParentProject {
    
    private string permittedCreationPathsField;
    
    private string excludedFilesField;
    
    private string requireProjectField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string PermittedCreationPaths {
        get {
            return this.permittedCreationPathsField;
        }
        set {
            this.permittedCreationPathsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ExcludedFiles {
        get {
            return this.excludedFilesField;
        }
        set {
            this.excludedFilesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string RequireProject {
        get {
            return this.requireProjectField;
        }
        set {
            this.requireProjectField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class TemplateTemplateFilesAspNetFile {
    
    private string fileTextField;
    
    private string nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string FileText {
        get {
            return this.fileTextField;
        }
        set {
            this.fileTextField = value;
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

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class NewDataSet {
    
    private Template[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Template")]
    public Template[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}
