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
    [System.Xml.Serialization.XmlTypeAttribute("resultatListeNoekler", Namespace="https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/sokeresultat/v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ResultatListeNoekler
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ResultatNoekler> _resultatNoekler;
        
        [System.Xml.Serialization.XmlElementAttribute("resultatNoekler")]
        public System.Collections.ObjectModel.Collection<ResultatNoekler> ResultatNoekler
        {
            get
            {
                return this._resultatNoekler;
            }
            private set
            {
                this._resultatNoekler = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResultatNoeklerSpecified
        {
            get
            {
                return (this.ResultatNoekler.Count != 0);
            }
        }
        
        /// <summary>
        /// </summary>
        public ResultatListeNoekler()
        {
            this._resultatNoekler = new System.Collections.ObjectModel.Collection<ResultatNoekler>();
        }
    }
}
