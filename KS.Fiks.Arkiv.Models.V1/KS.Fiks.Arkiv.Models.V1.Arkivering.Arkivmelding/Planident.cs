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
    [System.Xml.Serialization.XmlTypeAttribute("planident", Namespace="https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/arkivmelding/v1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Planident
    {
        
        /// <summary>
        /// <para>M3..</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("planidentifikasjon")]
        public string Planidentifikasjon { get; set; }
        
        /// <summary>
        /// <para>M3..</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.Xml.Serialization.XmlElementAttribute("kommunenummer")]
        public string Kommunenummer { get; set; }
        
        /// <summary>
        /// <para>M3..</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.Xml.Serialization.XmlElementAttribute("fylkesnummer")]
        public string Fylkesnummer { get; set; }
        
        /// <summary>
        /// <para>M3..</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.Xml.Serialization.XmlElementAttribute("landkode")]
        public string Landkode { get; set; }
    }
}
