//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.0.662.0
namespace KS.Fiks.Arkiv.Models.V1.Arkivering.Arkivmelding.Oppdatering
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.662.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("dokumentbeskrivelseOppdatering", Namespace="https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/arkivmeldingoppdater" +
        "ing/v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DokumentbeskrivelseOppdatering
    {
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("systemID")]
        public KS.Fiks.Arkiv.Models.V1.Metadatakatalog.SystemID SystemID { get; set; }
        
        /// <summary>
        /// <para>M020</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.Xml.Serialization.XmlElementAttribute("tittel")]
        public string Tittel { get; set; }
        
        /// <summary>
        /// <para>M021</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.Xml.Serialization.XmlElementAttribute("beskrivelse")]
        public string Beskrivelse { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("skjerming")]
        public KS.Fiks.Arkiv.Models.V1.Arkivering.Arkivmelding.Skjerming Skjerming { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("gradering")]
        public KS.Fiks.Arkiv.Models.V1.Arkivering.Arkivmelding.Gradering Gradering { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("dokumentobjekt")]
        public KS.Fiks.Arkiv.Models.V1.Arkivering.Arkivmelding.Dokumentobjekt Dokumentobjekt { get; set; }
    }
}
