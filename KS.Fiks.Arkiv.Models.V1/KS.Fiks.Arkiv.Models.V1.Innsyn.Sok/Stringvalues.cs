//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.0.662.0
namespace KS.Fiks.Arkiv.Models.V1.Innsyn.Sok
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.662.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("stringvalues", Namespace="https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/sok/v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Stringvalues
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<string> _value;
        
        [System.Xml.Serialization.XmlElementAttribute("value")]
        public System.Collections.ObjectModel.Collection<string> Value
        {
            get
            {
                return this._value;
            }
            private set
            {
                this._value = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValueSpecified
        {
            get
            {
                return (this.Value.Count != 0);
            }
        }
        
        /// <summary>
        /// </summary>
        public Stringvalues()
        {
            this._value = new System.Collections.ObjectModel.Collection<string>();
        }
    }
}
