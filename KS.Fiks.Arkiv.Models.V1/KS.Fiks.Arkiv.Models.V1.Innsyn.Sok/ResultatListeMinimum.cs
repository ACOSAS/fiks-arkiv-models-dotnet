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
    [System.Xml.Serialization.XmlTypeAttribute("resultatListeMinimum", Namespace="https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/sokeresultat/v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ResultatListeMinimum
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ResultatMinimum> _resultatMinimum;
        
        [System.Xml.Serialization.XmlElementAttribute("resultatMinimum")]
        public System.Collections.ObjectModel.Collection<ResultatMinimum> ResultatMinimum
        {
            get
            {
                return this._resultatMinimum;
            }
            private set
            {
                this._resultatMinimum = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResultatMinimumSpecified
        {
            get
            {
                return (this.ResultatMinimum.Count != 0);
            }
        }
        
        /// <summary>
        /// </summary>
        public ResultatListeMinimum()
        {
            this._resultatMinimum = new System.Collections.ObjectModel.Collection<ResultatMinimum>();
        }
    }
}
