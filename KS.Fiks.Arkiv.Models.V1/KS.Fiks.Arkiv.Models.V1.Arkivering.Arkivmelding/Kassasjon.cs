//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.0.662.0
namespace KS.Fiks.Arkiv.Models.V1.Arkivering.Arkivmelding
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.662.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("kassasjon", Namespace="https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/arkivmelding/v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("kassasjon", Namespace="https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/arkivmelding/v1")]
    public partial class Kassasjon
    {
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("kassasjonsvedtak")]
        public KS.Fiks.Arkiv.Models.V1.Metadatakatalog.Kassasjonsvedtak Kassasjonsvedtak { get; set; }
        
        /// <summary>
        /// <para>M453</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.Xml.Serialization.XmlElementAttribute("kassasjonshjemmel")]
        public string Kassasjonshjemmel { get; set; }
        
        /// <summary>
        /// <para>M451</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("bevaringstid")]
        public int Bevaringstid { get; set; }
        
        /// <summary>
        /// <para>M452</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("kassasjonsdato", DataType="date")]
        public System.DateTime Kassasjonsdato { get; set; }
    }
}
