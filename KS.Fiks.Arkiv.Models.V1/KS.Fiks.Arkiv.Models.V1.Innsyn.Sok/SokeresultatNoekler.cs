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
    [System.Xml.Serialization.XmlTypeAttribute("sokeresultatNoekler", Namespace="https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/sokeresultat/v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("sokeresultatNoekler", Namespace="https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/sokeresultat/v1")]
    public partial class SokeresultatNoekler
    {
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("system")]
        public string System { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("meldingId")]
        public string MeldingId { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("svarPaMeldingId")]
        public string SvarPaMeldingId { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("tidspunkt", DataType="dateTime")]
        public System.DateTime Tidspunkt { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("take")]
        public int Take { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("skip")]
        public int Skip { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("count")]
        public int Count { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("resultattype")]
        public ResultatTypeNoekler Resultattype { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ResultatNoekler> _resultatListe;
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlArrayAttribute("resultatListe")]
        [System.Xml.Serialization.XmlArrayItemAttribute("resultatNoekler", Namespace="https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/sokeresultat/v1")]
        public System.Collections.ObjectModel.Collection<ResultatNoekler> ResultatListe
        {
            get
            {
                return this._resultatListe;
            }
            private set
            {
                this._resultatListe = value;
            }
        }
        
        /// <summary>
        /// </summary>
        public SokeresultatNoekler()
        {
            this._resultatListe = new System.Collections.ObjectModel.Collection<ResultatNoekler>();
        }
    }
}
